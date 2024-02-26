using Business.Abstracts;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace WebApii.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        private readonly IBrandService _brandService;

        public BrandsController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        [HttpPost] //-> ekleme işlemleri için genelde kullanılır.
        public IActionResult Add(CreateBrandRequest createBrandRequest)
        {
            CreatedBrandResponses createdBrandResponses = _brandService.Add(createBrandRequest);

            return Ok(createdBrandResponses);
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_brandService.GetAll());
        }
    }
}

//404 -> Sayfa Bulunamadı
//401 -> Yetkisiz Bir İşlem
//200 -> Başarılı  => OK dediğimiz zaman döndürmüş oluruz
//201 -> Başarılı Aynı Zamanda Eklendi
