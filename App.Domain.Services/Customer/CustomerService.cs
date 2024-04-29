using App.Domain.Core.Customer.Data;
using App.Domain.Core.Customer.DTOs;
using App.Domain.Core.Customer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Services.Customer
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }
        public void CreateAddress(AddressDto addressDto)
        {
            throw new NotImplementedException();
        }

        public void CreateCity(CityDto cityDto)
        {
            throw new NotImplementedException();
        }

        public void CreateComment(CommentDto commentDto)
        {
            throw new NotImplementedException();
        }

        public void CreateCustomer(CustomerDto customerDto)
        {
            throw new NotImplementedException();
        }

        public void CreateProvince(ProvinceDto provinceDto)
        {
            throw new NotImplementedException();
        }

        public void CreateServiceRequest(ServiceRequestDto serviceRequestDto)
        {
            throw new NotImplementedException();
        }

        public void GetAddressById(int addressId)
        {
            throw new NotImplementedException();
        }

        public void GetAddresses()
        {
            throw new NotImplementedException();
        }

        public void GetCities()
        {
            throw new NotImplementedException();
        }

        public void GetCityById(int cityId)
        {
            throw new NotImplementedException();
        }

        public void GetCommentById(int commentId)
        {
            throw new NotImplementedException();
        }

        public void GetComments()
        {
            throw new NotImplementedException();
        }

        public void GetCustomerById(int customerId)
        {
            throw new NotImplementedException();
        }

        public void GetCustomers()
        {
            throw new NotImplementedException();
        }

        public void GetProvinceById(int provinceId)
        {
            throw new NotImplementedException();
        }

        public void GetProvinces()
        {
            throw new NotImplementedException();
        }

        public void GetServiceRequestById(int serviceId)
        {
            throw new NotImplementedException();
        }

        public void GetServiceRequests()
        {
            throw new NotImplementedException();
        }

        public void HardDeleteAddress(int addressId)
        {
            throw new NotImplementedException();
        }

        public void HardDeleteCity(int cityId)
        {
            throw new NotImplementedException();
        }

        public void HardDeleteComment(int commentId)
        {
            throw new NotImplementedException();
        }

        public void HardDeleteCustomer(int customerId)
        {
            throw new NotImplementedException();
        }

        public void HardDeleteProvince(int provinceId)
        {
            throw new NotImplementedException();
        }

        public void HardDeleteServiceRequest(int serviceId)
        {
            throw new NotImplementedException();
        }

        public void SoftDeleteAddress(int addressId)
        {
            throw new NotImplementedException();
        }

        public void SoftDeleteCity(int cityId)
        {
            throw new NotImplementedException();
        }

        public void SoftDeleteComment(int commentId)
        {
            throw new NotImplementedException();
        }

        public void SoftDeleteCustomer(int customerId)
        {
            throw new NotImplementedException();
        }

        public void SoftDeleteProvince(int provinceId)
        {
            throw new NotImplementedException();
        }

        public void SoftDeleteServiceRequest(int serviceId)
        {
            throw new NotImplementedException();
        }

        public void UpdateAddress(AddressDto addressDto)
        {
            throw new NotImplementedException();
        }

        public void UpdateCity(CityDto cityDto)
        {
            throw new NotImplementedException();
        }

        public void UpdateComment(CommentDto commentDto)
        {
            throw new NotImplementedException();
        }

        public void UpdateCustomer(CustomerDto customerDto)
        {
            throw new NotImplementedException();
        }

        public void UpdateProvince(ProvinceDto provinceDto)
        {
            throw new NotImplementedException();
        }

        public void UpdateServiceRequest(ServiceRequestDto serviceRequestDto)
        {
            throw new NotImplementedException();
        }
    }
}
