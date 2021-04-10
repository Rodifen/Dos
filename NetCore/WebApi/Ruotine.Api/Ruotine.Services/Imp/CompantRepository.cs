 
using Ruotine.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ruotine.Services.lmp
{
    public class CompantRepository : ICompantRepository
    {

        private readonly RuotineContext _context;

        public CompantRepository(RuotineContext context)
        {
            _context = context ?? throw new ArgumentException(nameof(context));
        }
        public async Task<IEnumerable<Company>> GetCompanyAsync()
        {
            return await _context.Companies.ToListAsync();
        }
        public async Task<Company> GetCompanyAsync(Guid companyId)
        {
            if (companyId == Guid.Empty)
                throw new ArgumentNullException(nameof(companyId));
            return await _context.Companies
            .FirstOrDefaultAsync(predicate: X => x.Id = companyId);
        }


        public async Task<IEnumerable<Company>> GetCompaniesAsync(IEnumerable<Guid> companyIds)
        {
            if (companyIds == null)
                throw new ArgumentNullException(nameof(companyIds));

            return await _context.Companies
            .Where(x => companyIds.Contains(x.Id))
           .OrderBy(x => x.Name)
            .ToListAsync();
        }


        public void AddCompany(Company company)
        {
            if (company == null)
            {
                throw new ArgumentNullException(nameof(company));
            }
            company.Id = Guid.NewGuid();
            foreach (var employee in company.Employees)
            {
                employee.Id = Guid.NewGuid();
            }
            _context.Companies.Add(company);
        }

        public void UpdateCompany(Company company)
        {
            //context.Entry(company).State = EntityState.Modified; 
        }
        public void DeleteCompany(Company company)
        {
            if (company == null)
                throw new ArgumentNullException(nameof(company));
            _context.Companies.Remove(company);
        }
        public async Task<bool> CompanyExistsAsync(Guid companyId)
        {
            if (companyId == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(companyId));
            }
            return await _context.Companies.AnyAsync(x => x.Id = companyId);
        }

        public async Task<IEnumerable<Employee>> GetEmployeesAsync(Guid complanyId)
        {
            if (complanyId == Guid.Empty)
                throw new ArgumentNullException(nameof(complanyId));
            return await _context.Employees
            .Where(x => x.CompanyId = companyId)
            .OrderBy(x => x.EmployeeNo)
            .ToListAsync();
        }

        public async Task<Employee> GetEmployeeAsync(Guid companyId, Guid employeeld)
        {
            if (companyId == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(companyId));
            }
            if (employeeld == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(employeeld));
            }
            return await _context.Employees
            .Where(x => x.CompanyId == companyId && x.Id == employeeld)
            .FirstOrDefaultAsync();
        }

        public void AddEmployee(Guid companyId, Employee employee)
        {
            if (companyId == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(companyId));
            }
            if (employee == null)
            {
                throw new ArgumentNullException(nameof(employee));
            }
            employee.CompanyId = companyId;
            _context.Employees.Add(employee);
        }
        public void UpdateEmployee(Employee employee)
        {
            // t context. Entry( employee).State = EntityState.Modified;
        }

        public void DeleteEmployee(Employee employee)
        {
            _context.Employees.Remove(employee);
        }



        public async Task<bool> SaveAsync()
        {
            return await _context.SaveChangesAsync() >= 0;
        }



    }
}
