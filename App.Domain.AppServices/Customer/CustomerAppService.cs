using App.Domain.Core.Customer.AppServices;
using App.Domain.Core.Customer.DTOs;
using App.Domain.Core.Customer.Entities;
using App.Domain.Core.Customer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.AppServices.Customer
{
    public class CustomerAppService : ICustomerAppService
    {
        private readonly ICustomerService _customerService;

        public CustomerAppService(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        public Address CreateAddress(AddressDto addressDto)
        {
            return _customerService.CreateAddress(addressDto);
        }

        public City CreateCity(CityDto cityDto)
        {
            return _customerService.CreateCity(cityDto);
        }

        public Comment CreateComment(CommentDto commentDto)
        {
            return _customerService.CreateComment(commentDto);
        }

        public Core.Customer.Entities.Customer CreateCustomer(CustomerDto customerDto)
        {
            return _customerService.CreateCustomer(customerDto);
        }

        public Province CreateProvince(ProvinceDto provinceDto)
        {
            return _customerService.CreateProvince(provinceDto);
        }

        public ServiceRequest CreateServiceRequest(ServiceRequestDto serviceRequestDto)
        {
            return _customerService.CreateServiceRequest(serviceRequestDto);
        }

        public Address GetAddressById(int addressId)
        {
            return _customerService.GetAddressById(addressId);
        }

        public List<Address> GetAddresses()
        {
            return _customerService.GetAddresses();
        }

        public List<City> GetCities()
        {
            return _customerService.GetCities();
        }

        public City GetCityById(int cityId)
        {
            return _customerService.GetCityById(cityId);
        }

        public Comment GetCommentById(int commentId)
        {
            return _customerService.GetCommentById(commentId);
        }

        public List<Comment> GetComments()
        {
            return _customerService.GetComments();
        }

        public Core.Customer.Entities.Customer GetCustomerById(int customerId)
        {
            return _customerService.GetCustomerById(customerId);
        }

        public List<Core.Customer.Entities.Customer> GetCustomers()
        {
            return _customerService.GetCustomers();
        }

        public Province GetProvinceById(int provinceId)
        {
            return _customerService.GetProvinceById(provinceId);
        }

        public List<Province> GetProvinces()
        {
            return _customerService.GetProvinces();
        }

        public ServiceRequest GetServiceRequestById(int serviceRequestId)
        {
            return _customerService.GetServiceRequestById(serviceRequestId);
        }

        public List<ServiceRequest> GetServiceRequests()
        {
            return _customerService.GetServiceRequests();
        }

        public Address HardDeleteAddress(int addressId)
        {
            return _customerService.HardDeleteAddress(addressId);
        }

        public City HardDeleteCity(int cityId)
        {
            return _customerService.HardDeleteCity(cityId);
        }

        public Comment HardDeleteComment(int commentId)
        {
            return _customerService.HardDeleteComment(commentId);
        }

        public Core.Customer.Entities.Customer HardDeleteCustomer(int customerId)
        {
            return _customerService.HardDeleteCustomer(customerId);
        }

        public Province HardDeleteProvince(int provinceId)
        {
            return _customerService.HardDeleteProvince(provinceId);
        }

        public ServiceRequest HardDeleteServiceRequest(int serviceRequestId)
        {
            return _customerService.HardDeleteServiceRequest(serviceRequestId);
        }

        public Address SoftDeleteAddress(int addressId)
        {
            return _customerService.SoftDeleteAddress(addressId);
        }

        public City SoftDeleteCity(int cityId)
        {
            return _customerService.SoftDeleteCity(cityId);
        }

        public Comment SoftDeleteComment(int commentId)
        {
            return _customerService.SoftDeleteComment(commentId);
        }

        public Core.Customer.Entities.Customer SoftDeleteCustomer(int customerId)
        {
            return _customerService.SoftDeleteCustomer(customerId);
        }

        public Province SoftDeleteProvince(int provinceId)
        {
            return _customerService.SoftDeleteProvince(provinceId);
        }

        public ServiceRequest SoftDeleteServiceRequest(int serviceId)
        {
            return _customerService.SoftDeleteServiceRequest(serviceId);
        }

        public Address UpdateAddress(AddressDto addressDto)
        {
            return _customerService.UpdateAddress(addressDto);
        }

        public City UpdateCity(CityDto cityDto)
        {
            return _customerService.UpdateCity(cityDto);
        }

        public Comment UpdateComment(CommentDto commentDto)
        {
            return _customerService.UpdateComment(commentDto);
        }

        public Core.Customer.Entities.Customer UpdateCustomer(CustomerDto customerDto)
        {
            return _customerService.UpdateCustomer(customerDto);
        }

        public Province UpdateProvince(ProvinceDto provinceDto)
        {
            return _customerService.UpdateProvince(provinceDto);
        }

        public ServiceRequest UpdateServiceRequest(ServiceRequestDto serviceRequestDto)
        {
            return _customerService.UpdateServiceRequest(serviceRequestDto);
        }
    }
}
