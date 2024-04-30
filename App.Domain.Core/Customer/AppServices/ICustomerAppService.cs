using App.Domain.Core.Customer.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Customer.AppServices
{
    public interface ICustomerAppService
    {
        public Customer.Entities.Customer CreateCustomer(CustomerDto customerDto);
        public Customer.Entities.Customer UpdateCustomer(CustomerDto customerDto);
        public Customer.Entities.Customer SoftDeleteCustomer(int customerId);
        public Customer.Entities.Customer HardDeleteCustomer(int customerId);
        public Customer.Entities.Customer GetCustomerById(int customerId);
        public List<Customer.Entities.Customer> GetCustomers();
        public Customer.Entities.Comment CreateComment(CommentDto commentDto);
        public Customer.Entities.Comment UpdateComment(CommentDto commentDto);
        public Customer.Entities.Comment SoftDeleteComment(int commentId);
        public Customer.Entities.Comment HardDeleteComment(int commentId);
        public Customer.Entities.Comment GetCommentById(int commentId);
        public List<Customer.Entities.Comment> GetComments();
        public Customer.Entities.ServiceRequest CreateServiceRequest(ServiceRequestDto serviceRequestDto);
        public Customer.Entities.ServiceRequest UpdateServiceRequest(ServiceRequestDto serviceRequestDto);
        public Customer.Entities.ServiceRequest SoftDeleteServiceRequest(int serviceId);
        public Customer.Entities.ServiceRequest HardDeleteServiceRequest(int serviceId);
        public Customer.Entities.ServiceRequest GetServiceRequestById(int serviceId);
        public List<Customer.Entities.ServiceRequest> GetServiceRequests();
        public Customer.Entities.Address CreateAddress(AddressDto addressDto);
        public Customer.Entities.Address UpdateAddress(AddressDto addressDto);
        public Customer.Entities.Address SoftDeleteAddress(int addressId);
        public Customer.Entities.Address HardDeleteAddress(int addressId);
        public Customer.Entities.Address GetAddressById(int addressId);
        public List<Customer.Entities.Address> GetAddresses();
        public Customer.Entities.City CreateCity(CityDto cityDto);
        public Customer.Entities.City UpdateCity(CityDto cityDto);
        public Customer.Entities.City SoftDeleteCity(int cityId);
        public Customer.Entities.City HardDeleteCity(int cityId);
        public Customer.Entities.City GetCityById(int cityId);
        public List<Customer.Entities.City> GetCities();
        public Customer.Entities.Province CreateProvince(ProvinceDto provinceDto);
        public Customer.Entities.Province UpdateProvince(ProvinceDto provinceDto);
        public Customer.Entities.Province SoftDeleteProvince(int provinceId);
        public Customer.Entities.Province HardDeleteProvince(int provinceId);
        public Customer.Entities.Province GetProvinceById(int provinceId);
        public List<Customer.Entities.Province> GetProvinces();
    }
}
