﻿using EMovieTickets.Data;
using EMovieTickets.Data.Services;
using EMovieTickets.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EMovieTickets.Controllers
{
    public class ProducersController : Controller
    {
        private readonly IProducersService _service;
        public ProducersController(IProducersService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var allProducers = await _service.GetAllAsync();
            return View(allProducers);
        }

        //GET: producers/details/1
        public  async Task<IActionResult> Details(int id)
        {
            var producerDetails = await _service.GetByIdAsync(id);
            if (producerDetails == null ) return View("NotFound"); 
            return View(producerDetails);
        }

        //Get: producers/Create
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Create([Bind("ProfilePictureURL", "FullName", "Bio")]Producer producer)
        {
            if(!ModelState.IsValid) return View(producer);
            await _service.AddAsync(producer);
            return RedirectToAction(nameof(Index));

        }

        //GET: producer/Edit

        public async Task<IActionResult> Edit(int id)
        {
            var producerDetails = await _service.GetByIdAsync(id);
            if (producerDetails == null ) return View("NotFound");
            return View(producerDetails);
        }


        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("ProfilePictureURL", "FullName", "Bio")] Producer producer)
        {
            producer.Id = id;
            if (!ModelState.IsValid) return View(producer);
            await _service.UpdateAsync(id, producer);
            return RedirectToAction(nameof(Index));

        }

        //GET: producers/delete/1
        public async Task<IActionResult> Delete(int id)
        {
            var producerDetails = await _service.GetByIdAsync(id);
            if (producerDetails == null) return View("NotFound");
            return View(producerDetails);
        }


        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var producerDetails = await _service.GetByIdAsync(id);
            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));

        }
    }
}
