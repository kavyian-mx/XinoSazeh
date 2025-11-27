using AutoMapper;
using ENDPOINTs.Models.DTOs;
using Microsoft.AspNetCore.Mvc;
using xino.SERVICE.Services;
using xino.DEL.Entity;
using System.Threading.Tasks;

namespace ENDPOINTs.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class ProjectController : Controller
    {
        private readonly ProjectService _service;
        private readonly IMapper _mapper;

        public ProjectController(ProjectService projectService, IMapper mapper)
        {
            _service = projectService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var project = await _service.GetAllAsync();
            var dto = _mapper.Map<List<ProjectListDTOs>>(project);
            return View(dto);
        }

        public async Task<IActionResult> Deleted()
        {

            var project = await _service.SoftDeleted();
            var dto = _mapper.Map<List<ProjectListDTOs>>(project);

            return View(dto);

        }

        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProjectCreateDTOs model)
        {
            Console.WriteLine("POST HIT ✅");

            Console.WriteLine("Header: " + (model.HeaderImageFile == null ? "NULL" : "OK"));
            Console.WriteLine("Gallery: " + (model.GalleryImagesFiles?.Count ?? 0));

            if (!ModelState.IsValid)
            {
                foreach (var item in ModelState)
                {
                    foreach (var err in item.Value.Errors)
                    {
                        Console.WriteLine($"❌ {item.Key} => {err.ErrorMessage}");
                    }
                }

                return View(model);
            }

            var uploadPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/projects");

            if (!Directory.Exists(uploadPath))
                Directory.CreateDirectory(uploadPath);

            if (model.HeaderImageFile != null)
            {
                string headerFileName = Guid.NewGuid() + Path.GetExtension(model.HeaderImageFile.FileName);
                string headerPath = Path.Combine(uploadPath, headerFileName);

                using var stream = new FileStream(headerPath, FileMode.Create);
                await model.HeaderImageFile.CopyToAsync(stream);

                model.HeaderImage = "/uploads/projects/" + headerFileName;
            }

            var galleryList = new List<GalleryImageProject>();

            if (model.GalleryImagesFiles != null && model.GalleryImagesFiles.Any())
            {
                int order = 1;
                foreach (var file in model.GalleryImagesFiles)
                {
                    string fileName = Guid.NewGuid() + Path.GetExtension(file.FileName);
                    string filePath = Path.Combine(uploadPath, fileName);

                    using var stream = new FileStream(filePath, FileMode.Create);
                    await file.CopyToAsync(stream);

                    galleryList.Add(new GalleryImageProject
                    {
                        ImageUrl = "/uploads/projects/" + fileName,
                        Order = order++
                    });
                }
            }

            var entity = _mapper.Map<Project>(model);
            entity.GalleryImageProject = galleryList;

            await _service.AddAsync(entity);

            return RedirectToAction("Index");
        }


        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var project = await _service.GetByIdAsync(id);

            if (project == null)
                return NotFound();

            var dto = _mapper.Map<ProjectListDTOs>(project);

            return View(dto);
        }

    }
}
