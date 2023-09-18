using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using EcoPower_Logistics.Reopository; // Assuming this is where your CustomerRepository is located
using Models; // Assuming you have a Customer model
using System.Threading.Tasks;
using System.Linq;
using static EcoPower_Logistics.Reopository.CustomersRepository;
using ICustomerRepository = EcoPower_Logistics.Reopository.CustomersRepository.ICustomerRepository;

namespace Controllers
{

    [Authorize]
    public class CustomersController : Controller
    {

        private readonly ICustomerRepository _customerRepository;

        public CustomersController(ICustomerRepository CustomerRepository)
        {
            _customerRepository = CustomerRepository;
        }

        // GET: Customers
        public async Task<IActionResult> Index()
        {
            var customers = _customerRepository.GetAllCustomers();
            return View(customers);
        }

        // GET: Customers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = _customerRepository.GetCustomerById(id.Value);

            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // GET: Customers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Customers/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CustomerId,CustomerTitle,CustomerName,CustomerSurname,CellPhone")] EcoPower_Logistics.Reopository.CustomersRepository.Customer customer)
        {
            if (ModelState.IsValid)
            {
                _customerRepository.AddCustomer(customer);
                return RedirectToAction(nameof(Index));
            }
            return View(customer);
        }

        // GET: Customers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = _customerRepository.GetCustomerById(id.Value);

            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // POST: Customers/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CustomerId,CustomerTitle,CustomerName,CustomerSurname,CellPhone")] EcoPower_Logistics.Reopository.CustomersRepository.Customer customer)
        {
            if (id != customer.CustomerId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _customerRepository.UpdateCustomer(customer);
                return RedirectToAction(nameof(Index));
            }
            return View(customer);
        }

        // GET: Customers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = _customerRepository.GetCustomerById(id.Value);

            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // POST: Customers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var customer = _customerRepository.GetCustomerById(id);

            if (customer != null)
            {
                _customerRepository.DeleteCustomer(id);
                return RedirectToAction(nameof(Index));
            }

            return NotFound();
        }
    }
}
