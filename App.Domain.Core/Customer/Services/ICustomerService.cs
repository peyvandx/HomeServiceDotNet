using App.Domain.Core.Customer.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Customer.Services
{
    public interface ICustomerService
    {
        public void CreateCustomer(CustomerDto customerDto);
        public void UpdateCustomer(CustomerDto customerDto);
        public void SoftDeleteCustomer(int customerId);
        public void HardDeleteCustomer(int customerId);
        public void GetCustomerById(int customerId);
        public void GetCustomers();
        public void CreateComment(CommentDto commentDto);
        public void UpdateComment(CommentDto commentDto);
        public void SoftDeleteComment(int commentId);
        public void HardDeleteComment(int commentId);
        public void GetCommentById(int commentId);
        public void GetComments();
        public void CreateServiceRequest(ServiceRequestDto serviceRequestDto);
        public void UpdateServiceRequest(ServiceRequestDto serviceRequestDto);
        public void SoftDeleteServiceRequest(int serviceId);
        public void HardDeleteServiceRequest(int serviceId);
        public void GetServiceRequestById(int serviceId);
        public void GetServiceRequests();
        public void CreateAddress(AddressDto addressDto);
        public void UpdateAddress(AddressDto addressDto);
        public void SoftDeleteAddress(int addressId);
        public void HardDeleteAddress(int addressId);
        public void GetAddressById(int addressId);
        public void GetAddresses();
        public void CreateCity(CityDto cityDto);
        public void UpdateCity(CityDto cityDto);
        public void SoftDeleteCity(int cityId);
        public void HardDeleteCity(int cityId);
        public void GetCityById(int cityId);
        public void GetCities();
        public void CreateProvince(ProvinceDto provinceDto);
        public void UpdateProvince(ProvinceDto provinceDto);
        public void SoftDeleteProvince(int provinceId);
        public void HardDeleteProvince(int provinceId);
        public void GetProvinceById(int provinceId);
        public void GetProvinces();
    }
}
