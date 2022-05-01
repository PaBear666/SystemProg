using BLL.Analyzer;

namespace App.Models.Abstractions
{
    public interface IAnalyzerModel
    {
        /// <summary>
        /// Выполнить обработку кода
        /// </summary>
        /// <param name="code">Код</param>
        /// <returns>Результат обработки</returns>
        AnalyzerResult Execute(string code);

        
        /// <summary>
        /// Установить конструкцию C#
        /// </summary>
        /// <param name="design">конструкция C#</param>
        void SetDesign(CsharpDesign design);
    }
}