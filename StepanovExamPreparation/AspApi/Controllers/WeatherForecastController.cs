using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace AspApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentsController : ControllerBase
    {
        private List<Student> _students; // ������ ���������, � ������� �� ��������

        private string _pathToJson; // ������ ���� �� json ����� �� ����������

        public StudentsController()
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "appsettings.json");
            // �������� ������������ ������� ��� ���� ���� �� �����
            var config = new ConfigurationBuilder().AddJsonFile(filePath).Build();
            _pathToJson = config["Path"]; // ���� �� ����� �� ����������, ������� �� ������� � appsettings.json

            if (System.IO.File.Exists(_pathToJson)) //�������� ���� ���� ����������
            {
                string jsonString = System.IO.File.ReadAllText(_pathToJson); // ��������� ��� ������ � ����� � ���� json ������
                List<Student> students = JsonSerializer.Deserialize<List<Student>>(jsonString); // ����������� json � ������ ���������

                if (students != null)
                {
                    _students = students;
                }
                else
                    throw new Exception("No students, list is null");
            }
            else // ���� ���� �� ������ �� Exception
            {
                throw new Exception("Can't find file");
            }
        }

        //� ������� �������� ����� ����� ������ �������������������� � ��������

        /// <summary>
        /// return list of students
        /// </summary>
        /// <returns></returns>
        [HttpGet, Route("students")]
        public List<Student> GetStudents()
        {
            return _students;
        }

        /// <summary>
        /// return student by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        [HttpGet, Route("students/{id}")]
        public Student GetStudentById(int id)
        {
            var student = _students.FirstOrDefault(s => s.Id == id);
            if (student == null) throw new Exception("Student with id not found");
            return student;
        }

        /// <summary>
        /// add new student
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        [HttpPost, Route("addstudents/{id}/{name}")]
        public void AddStudent(int id, string name)
        {
            Student student = new Student { Id = id, Name = name }; //������� ������ �������� 

            _students.Add(student); //��������� ��� � ��� ������
            string json = JsonSerializer.Serialize(_students); // ������ �� ������ json ������
            System.IO.File.WriteAllText(_pathToJson, json); //�������������� json � ����

        }

    }
}
