using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace BLL.Analyzer
{
    public class Analyzer
    {
        public AnalyzerResult Result { get; set; }

        public void Excecute(string code, CsharpDesign design)
        {
            Result = new AnalyzerResult();
            code = Regex.Replace(code, @"\s+", " ");
            var guid = Guid.NewGuid();
            var guid2 = Guid.NewGuid();

            CodeDomProvider codeProvider = CodeDomProvider.CreateProvider("CSharp");
            string output = "Outasd.exe";
            CompilerParameters parameters = new CompilerParameters
            {
                GenerateExecutable = true,
                OutputAssembly = output
            };

            switch (design)
            {
                case CsharpDesign.DoWhile:
                    if (code.Contains("while") && code.Contains("do") && DoWhileInsertGuid(ref code, guid))
                    {
                        var compiledCode = string.Format("using System; namespace Compilator\n {{ class Program{{static void Main(string[] args){{{0}}}}}}}", code);
                        // создаём exeFile
                        CompilerResults results = codeProvider.CompileAssemblyFromSource(parameters, compiledCode);

                        if (results.Errors.HasErrors)
                        {
                            Fail("Неверный синтаксис");
                            return;
                        }

                        var process = InitProcess(output);
                        var value = "";
                        // Запускаем процесс
                        process.Start();

                        while (!process.StandardOutput.EndOfStream)
                        {
                            if (process.StandardOutput.ReadLine() == guid.ToString())
                            {
                                value = value.ToString() + 1;
                                if (int.Parse(value) > 100)
                                {
                                    process.Kill();
                                    Complited("Да");
                                    return;
                                }
                            }
                        }
                        process.Close();
                        string result = int.Parse(value) > 0 ? "Да" : "Нет";
                        Complited(result);       
                        return;
                    }
                    break;

                case CsharpDesign.If:
                    if(code.Contains("if") && code.Contains("else") && IfInsertGuid(ref code, guid, guid2))
                    {
                        var compiledCode = string.Format("using System; namespace Compilator\n {{ class Program{{static void Main(string[] args){{{0}}}}}}}", code);
                        // создаём exeFile
                        CompilerResults results = codeProvider.CompileAssemblyFromSource(parameters, compiledCode);

                        if (results.Errors.HasErrors)
                        {
                            Fail("Неверный синтаксис");
                            return;
                        }

                        var process = InitProcess(output);
                        var value = "";
                        // Запускаем процесс
                        process.Start();

                        while (!process.StandardOutput.EndOfStream)
                        {
                            var outPut = process.StandardOutput.ReadLine();
                            if (outPut == guid.ToString())
                            {
                                value = "if";
                            }
                            if (outPut == guid2.ToString())
                            {
                                value = "else";
                            }
                        }
                        process.Close();
                        Complited(value);
                        return;
                    }
                    break;
            }
            
            Fail("Неверный синтаксис");
        }

        private bool DoWhileInsertGuid(ref string code, Guid guid)
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

        private bool IfInsertGuid(ref string code, Guid guid, Guid guid2)
        {
            var codes = code.Split(new[] { '{', '}' });
            if (codes.Length == 5)
            {
                codes[1] += $"Console.WriteLine(\"{guid}\");";
                codes[3] += $"Console.WriteLine(\"{guid2}\");";

                code = codes[0] + "{" + codes[1] + "}" + codes[2] + "{" + codes[3] + "}" + codes[4];
                return true;
            }
            return false;
        }

        private void Fail()
        {
            Result.Compiled = false;
            Result.Value = "";
        }

        private void Fail(string mes)
        {
            Fail();
            Result.Message = mes;
        }

        private void Complited(string value)
        {
            Result.Compiled = true;
            Result.Value = value;
        }

        private Process InitProcess(string output)
        {
            Process process = new Process();
            // Задаём стартовые параметры 
            process.StartInfo.FileName = output;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = false;
            process.StartInfo.UseShellExecute = false;
            return process;
        }
    }
}
