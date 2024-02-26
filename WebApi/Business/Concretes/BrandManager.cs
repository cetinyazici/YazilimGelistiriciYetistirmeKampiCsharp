using Business.Abstracts;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Entities.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes;

public class BrandManager : IBrandService
{
    private readonly IBrandDal _brandDal;

    public BrandManager(IBrandDal brandDal)
    {
        _brandDal = brandDal;
    }

    public CreatedBrandResponses Add(CreateBrandRequest createBrandRequest)
    {
        //business rules

        //mapping -> automapper
        Brand brand = new();
        brand.Name= createBrandRequest.Name;
        brand.CreatedDate = DateTime.Now;
        _brandDal.Add(brand);

        //mapping
        CreatedBrandResponses createdBrandResponses = new CreatedBrandResponses();
        createdBrandResponses.Name = brand.Name;
        createdBrandResponses.Id = 4;
        createdBrandResponses.CreatedDate = brand.CreatedDate;
        
        return createdBrandResponses;
    }

    public List<GettAllBrandResponses> GetAll()
    {
        List<Brand> brands = _brandDal.GettAll();
        List<GettAllBrandResponses> gettAllBrandResponses = new List<GettAllBrandResponses>();

        foreach (var brand in brands)
        {
            GettAllBrandResponses gettAllBrandResponse = new GettAllBrandResponses();
            gettAllBrandResponse.Name = brand.Name;
            gettAllBrandResponse.Id = brand.Id;
            gettAllBrandResponse.CreatedDate=brand.CreatedDate;

            gettAllBrandResponses.Add(gettAllBrandResponse);
        }

        return gettAllBrandResponses;
    }
}
