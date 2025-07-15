using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using todoListApi.Data;

namespace todoListApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private readonly DataContext _data;
        public TodoController(DataContext data) {

            _data = data;

        }
        [HttpGet]
        public IActionResult List()
        {
            var value = _data.Gorevs.ToList();
            return Ok(value);
        }
        [HttpPost]
        public IActionResult Ekle(Görev gorev)
        {
            _data.Gorevs.Add(gorev);
            _data.SaveChanges();
            return Ok();
        }
        [HttpDelete]
        public IActionResult Delete(int id) {
            var value = _data.Gorevs.Find(id);
            _data.Gorevs.Remove(value);
            _data.SaveChanges();
            return Ok();
        }
        [HttpPut]
        public IActionResult Guncelle(Görev gorev)
        {
            _data.Gorevs.Update(gorev);
            _data.SaveChanges();
            return Ok();
        }
    }
}
