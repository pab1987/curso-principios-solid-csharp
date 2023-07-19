using SingleResponsability;

StudentRepository studentRepository = new();
ExportHelper exportHelper = new();
exportHelper.ExportStudentsCsv(studentRepository.GetAll());
Console.WriteLine("Proceso Completado");