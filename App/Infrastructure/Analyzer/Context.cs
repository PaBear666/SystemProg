using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Text;
using System.Text.RegularExpressions;

namespace App.Infrastructure.Analyzer
{
    public class Context
    {
        public AnalyzerResult Result { get; }

        public Context(string code)
        {
            Result = new AnalyzerResult();
            code = Regex.Replace(code, @"\s+", " ");
            var guid = Guid.NewGuid();
            if (AddCWToBody(ref code, guid) && code.Contains("while") || code.Contains("do"))
            {
                var compiledCode = string.Format("using System; namespace Compilator\n {{ class Program{{static void Main(string[] args){{{0}}}}}}}", code);
                CodeDomProvider codeProvider = CodeDomProvider.CreateProvider("CSharp");
                // Имя файла
                string Output = "Outasd.exe";
                CompilerParameters parameters = new CompilerParameters
                {
                    GenerateExecutable = true,
                    OutputAssembly = Output
                };

                // создаём exeFile
                CompilerResults results = codeProvider.CompileAssemblyFromSource(parameters, compiledCode);

                if (results.Errors.HasErrors)
                {
                    Fail("Неверный синтаксис");
                    return;
                }

                Process process = new Process();
                // Задаём стартовые параметры 
                process.StartInfo.FileName = Output;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.CreateNoWindow = false;
                process.StartInfo.UseShellExecute = false;

                // В StringBuilder будем добавлять полученные данные
                int value = 0;

                // Запускаем процесс
                process.Start();

                while (!process.StandardOutput.EndOfStream)
                {
                    if (process.StandardOutput.ReadLine() == guid.ToString())
                    {
                        value++;
                        if (value > 100)
                        {
                            process.Kill();
                            Fail("Бесконечный цикл");
                            return;
                        }
                    }
                }
                Complited(value);
                process.Close();
                return;
            }
            Fail("Неверный синтаксис");
        }

        private bool AddCWToBody(ref string code,Guid guid)
        {
           var codes = code.Split(new[] { '{', '}' });
            if (codes.Length == 3)
            {
                codes[1] += $"Console.WriteLine(\"{guid}\");";

                code = codes[0] + "{" + codes[1] + "}" + codes[2];
                return true;
           }

           return false;
        }

        private void Fail()
        {
            Result.Compiled = false;
            Result.Value = 0;
        }

        private void Fail(string mes)
        {
            Fail();
            Result.Message = mes;
        }

        private void Complited(int value)
        {
            Result.Compiled = true;
            Result.Value = value;
        }
    }
}
