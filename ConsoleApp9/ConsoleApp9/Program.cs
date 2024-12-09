using System;

namespace ReportGeneratorExample
{
    // 1. Абстрактный класс ReportGenerator
    public abstract class ReportGenerator
    {
        // Шаблонный метод
        public void GenerateReport()
        {
            CollectData();
            ProcessData();
            FormatReport();
            ExportReport();
        }

        // Абстрактные методы
        protected abstract void CollectData();
        protected abstract void ProcessData();
        protected abstract void FormatReport();

        // Конкретный метод
        protected void ExportReport()
        {
            Console.WriteLine("Отчет экспортирован.");
        }
    }

    // Конкретный класс StudentReportGenerator
    public class StudentReportGenerator : ReportGenerator
    {
        protected override void CollectData()
        {
            Console.WriteLine("Собраны данные о студентах.");
        }

        protected override void ProcessData()
        {
            Console.WriteLine("Обработаны данные о студентах.");
        }

        protected override void FormatReport()
        {
            Console.WriteLine("Отчет о студентах отформатирован.");
        }
    }

    // Конкретный класс CourseReportGenerator
    public class CourseReportGenerator : ReportGenerator
    {
        protected override void CollectData()
        {
            Console.WriteLine("Собраны данные о курсах.");
        }

        protected override void ProcessData()
        {
            Console.WriteLine("Обработаны данные о курсах.");
        }

        protected override void FormatReport()
        {
            Console.WriteLine("Отчет по курсам отформатирован.");
        }
    }

    // Пример использования
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Генерация отчета о студентах:");
            ReportGenerator studentReport = new StudentReportGenerator();
            studentReport.GenerateReport();

            Console.WriteLine();

            Console.WriteLine("Генерация отчета по курсам:");
            ReportGenerator courseReport = new CourseReportGenerator();
            courseReport.GenerateReport();
        }
    }
}