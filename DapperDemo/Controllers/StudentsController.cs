using DapperDemo.Models;
using DapperDemo.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace DapperDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : Controller
    {
        private readonly StudentRepository _repo;
        public StudentsController(StudentRepository repo)
        {
            _repo=repo;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var students=await _repo.GetAllAsync();
            return Ok(students);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var student=await _repo.GetByIdAsync(id);
            return Ok(student);
        }
        [HttpPost]
        public async Task<IActionResult> Create(Student student)
        {
            await _repo.CreateAsync(student);
            return Ok("Student Created successfully");
        }
        [HttpPut("id")]
        public async Task<IActionResult> Update(Student student)
        {
            await _repo.UpdateAsync(student);
            return Ok("Student updated successfully");
        }
        [HttpDelete("id")]
        public async Task<IActionResult>Delete(int id)
        {
            await _repo.DeleteAsync(id);
            return Ok("Student deleted successfully");
        }
       
    }
}
