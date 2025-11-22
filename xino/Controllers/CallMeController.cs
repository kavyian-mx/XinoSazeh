using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ENDPOINTs.Models.DTOs;
using xino.SERVICE.Service;
using xino.DEL.Entity;

namespace ENDPOINTs.Controllers
{
    public class CallMeController : Controller
    {
        private readonly ConsultationService _consultationService;
        private readonly IMapper _mapper;

        // تزریق سرویس و AutoMapper
        public CallMeController(ConsultationService consultationService, IMapper mapper)
        {
            _consultationService = consultationService;
            _mapper = mapper;
        }

        // GET: /CallMe یا /CallMe/Index
        [HttpGet]
        public IActionResult Index()
        {
            return View(new ConsultationCreateDto());
        }

        // POST: ایجاد درخواست مشاوره
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateConsultation(ConsultationCreateDto dto)
        {
            if (!ModelState.IsValid)
            {
                // اگر خطا داشت، همون فرم با داده‌ها و خطاها برگرده
                return View("Index", dto);
            }

            try
            {
                // تبدیل DTO به Entity با AutoMapper
                var consultation = _mapper.Map<Consultation>(dto);

                // تنظیمات اضافی (مثل تاریخ ساخت و وضعیت چک نشده)
                consultation.BuildDate = DateTime.Now;
                consultation.IsChacket = false; // پیش‌فرض: هنوز چک نشده

                await _consultationService.Create(consultation);

                TempData["Success"] = "درخواست مشاوره شما با موفقیت ثبت شد. به زودی با شما تماس خواهیم گرفت";

                // برگرد به صفحه اصلی (همون Index) تا پیام موفقیت نمایش داده بشه
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                // در صورت خطای دیتابیس یا ...
                ModelState.AddModelError("", "خطایی در ثبت درخواست رخ داد. لطفاً مجدد تلاش کنید.");
                return View("Index", dto);
            }
        }
    }
}