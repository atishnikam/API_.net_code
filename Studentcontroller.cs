using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Studentcontroller : ControllerBase
    {
        static List<student> students = new List<student>();

        // GET: api/<Studentcontroller>
        [HttpGet]
        public IEnumerable<student> Get()
        {
            return students;
        }

        // GET api/<Studentcontroller>/5
        [HttpGet("{id}")]
        public student Get(int id)
        {
            return students.FirstOrDefault(s => s.ID == id);
        }

        // POST api/<Studentcontroller>
        [HttpPost]
        public void Post([FromBody] student value)
        {
            students.Add(value);
        }

        // PUT api/<Studentcontroller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] student value)
        {
            int i = students.FindIndex(s => s.ID == id);
            if (i >= 0)
            {
                students[i] = value;
            }
        }

        // DELETE api/<Studentcontroller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            students.RemoveAll(s => s.ID == id);
        }
    }


    // Employee
    public class Employeecontroller : ControllerBase
    {
        static List<Employee> employyes = new List<Employee>();
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return employyes;
        }
        [HttpGet("{id}")]
        public Employee Get(int id)
        {
            return employyes.FirstOrDefault(s => s.ID == id);
        }


        [HttpPost]
        public void Post([FromBody] Employee value)
        {
            employyes.Add(value);
        }
        // PUT api/<Studentcontroller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Employee value)
        {
            int i = employyes.FindIndex(s => s.ID == id);
            if (i >= 0)
            {
                employyes[i] = value;
            }
        }
        // DELETE api/<Studentcontroller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            employyes.RemoveAll(s => s.ID == id);
        }


        public class Managercontroller : ControllerBase
        {
            static List<Manager> managers = new List<Manager>();
            static List<Manager> emplmanagers = new List<EmpManager>();




        
        }
    }
    }

