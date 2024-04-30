using App.Domain.Core.Customer.DTOs;
using App.Domain.Core.Customer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Customer.Data
{
    public interface ICustomerRepository
    {
        public Customer.Entities.Customer CreateCustomer(Customer.Entities.Customer signingUpCustomer);
        public Customer.Entities.Customer UpdateCustomer(Customer.Entities.Customer updatedCustomer);
        public Customer.Entities.Customer SoftDeleteCustomer(int customerId);
        public Customer.Entities.Customer HardDeleteCustomer(int customerId);
        public Customer.Entities.Customer GetCustomerById(int customerId);
        public List<Customer.Entities.Customer> GetCustomers();
        public Customer.Entities.Comment CreateComment(Customer.Entities.Comment submittedComment);
        public Customer.Entities.Comment UpdateComment(Customer.Entities.Comment updatedComment);
        public Customer.Entities.Comment SoftDeleteComment(int commentId);
        public Customer.Entities.Comment HardDeleteComment(int commentId);
        public Customer.Entities.Comment GetCommentById(int commentId);
        public List<Customer.Entities.Comment> GetComments();
        public Customer.Entities.ServiceRequest CreateServiceRequest(Customer.Entities.ServiceRequest submittedServiceRequest);
        public Customer.Entities.ServiceRequest UpdateServiceRequest(ServiceRequest updatedServiceRequest);
        public Customer.Entities.ServiceRequest SoftDeleteServiceRequest(int serviceId);
        public Customer.Entities.ServiceRequest HardDeleteServiceRequest(int serviceId);
        public Customer.Entities.ServiceRequest GetServiceRequestById(int serviceId);
        public List<Customer.Entities.ServiceRequest> GetServiceRequests();
        public Customer.Entities.Address CreateAddress(Customer.Entities.Address submittedAddress);
        public Customer.Entities.Address UpdateAddress(Customer.Entities.Address updatedAddress);
        public Customer.Entities.Address SoftDeleteAddress(int addressId);
        public Customer.Entities.Address HardDeleteAddress(int addressId);
        public Customer.Entities.Address GetAddressById(int addressId);
        public List<Customer.Entities.Address> GetAddresses();
        public Customer.Entities.City CreateCity(Customer.Entities.City submittedCity);
        public Customer.Entities.City UpdateCity(Customer.Entities.City updatedCity);
        public Customer.Entities.City SoftDeleteCity(int cityId);
        public Customer.Entities.City HardDeleteCity(int cityId);
        public Customer.Entities.City GetCityById(int cityId);
        public List<Customer.Entities.City> GetCities();
        public Customer.Entities.Province CreateProvince(Customer.Entities.Province submittedProvince);
        public Customer.Entities.Province UpdateProvince(Customer.Entities.Province updatedProvince);
        public Customer.Entities.Province SoftDeleteProvince(int provinceId);
        public Customer.Entities.Province HardDeleteProvince(int provinceId);
        public Customer.Entities.Province GetProvinceById(int provinceId);
        public List<Customer.Entities.Province> GetProvinces();
    }
}
