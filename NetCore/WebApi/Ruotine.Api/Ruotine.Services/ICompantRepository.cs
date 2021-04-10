using Ruotine.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ruotine.Services
{
    public interface ICompantRepository
    {

        Task<IEnumerable<Company>> GetCompanyAsync();

        Task<Company> GetCompanyAsync(Guid companyId);

        Task<IEnumerable<Company>> GetCompaniesAsync(IEnumerable<Guid> companyIds);

        void AddCompany(Company company);

        void UpdateCompany(Company company);

        void DeleteCompany(Company
        company);

        Task<bool> CompanyExistsAsync(Guid companyId);

        Task<IEnumerable<Employee>> GetEmployeesAsync(Guid companyId);

        Task<Employee> GetEmployeeAsync(Guid companyId, Guid employeeId);

        void AddEmployee(Guid companyId, Employee employee);
        void UpdateEmployee(Employee employee);
        void DeleteEmployee(Employee employee);
        Task<bool> SaveAsync();


    }
}
