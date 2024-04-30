using App.Domain.Core.Customer.Data;
using App.Domain.Core.Customer.DTOs;
using App.Domain.Core.Customer.Entities;
using App.Domain.Core.Customer.Enums;
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

        public Address CreateAddress(AddressDto addressDto)
        {
            var creatingAddress = new Address();
            creatingAddress.CreatedAt = DateTime.Now;
            creatingAddress.Street = addressDto.Street;
            creatingAddress.PostalCode = addressDto.PostalCode;
            creatingAddress.CityId = addressDto.CityId;
            creatingAddress.CustomerId = addressDto.CustomerId;
            creatingAddress.ExpertId = addressDto.ExpertId;
            return _customerRepository.CreateAddress(creatingAddress);
        }

        public City CreateCity(CityDto cityDto)
        {
            var creatingCity = new City();
            creatingCity.CreatedAt = DateTime.Now;
            creatingCity.Name = cityDto.Name;
            creatingCity.ProvinceId = cityDto.ProvinceId;
            return _customerRepository.CreateCity(creatingCity);
        }

        public Comment CreateComment(CommentDto commentDto)
        {
            var submittedComment = new Comment();
            submittedComment.CreateDate = DateTime.Now;
            submittedComment.Description = commentDto.Description;
            submittedComment.Rate = commentDto.Rate;
            submittedComment.CustomerId = commentDto.CustomerId;
            submittedComment.ExpertId = commentDto.ExpertId;
            submittedComment.AdminId = commentDto.AdminId; //will fix later
            return _customerRepository.CreateComment(submittedComment);
        }

        public Core.Customer.Entities.Customer CreateCustomer(CustomerDto customerDto)
        {
            var signingUpCustomer = new Core.Customer.Entities.Customer();
            signingUpCustomer.SignUpDate = DateTime.Now;
            signingUpCustomer.FirstName = customerDto.FirstName;
            signingUpCustomer.LastName = customerDto.LastName;
            signingUpCustomer.PhoneNumber = customerDto.PhoneNumber;
            signingUpCustomer.ProfileImage = customerDto.ProfileImage;
            signingUpCustomer.AdminId = customerDto.AdminId; //will fix later
            return _customerRepository.CreateCustomer(signingUpCustomer);
        }

        public Province CreateProvince(ProvinceDto provinceDto)
        {
            var creatingProvince = new Province();
            creatingProvince.CreatedAt = DateTime.Now;
            creatingProvince.Name = provinceDto.Name;
            return _customerRepository.CreateProvince(creatingProvince);
        }

        public ServiceRequest CreateServiceRequest(ServiceRequestDto serviceRequestDto)
        {
            var creatingServiceRequest = new ServiceRequest();
            creatingServiceRequest.CreatedAt = DateTime.Now;
            creatingServiceRequest.Status = Status.WaitingForExpertsProposals;
            creatingServiceRequest.CustomerDescription = serviceRequestDto.CustomerDescription;
            creatingServiceRequest.Price = serviceRequestDto.Price;
            creatingServiceRequest.CustomerId = serviceRequestDto.CustomerId;
            creatingServiceRequest.ExpertId = serviceRequestDto.ExpertId;
            creatingServiceRequest.ServiceId = serviceRequestDto.ServiceId;
            return _customerRepository.CreateServiceRequest(creatingServiceRequest);
        }

        public Address GetAddressById(int addressId)
        {
            return _customerRepository.GetAddressById(addressId);
        }

        public List<Address> GetAddresses()
        {
            return _customerRepository.GetAddresses();
        }

        public List<City> GetCities()
        {
            return _customerRepository.GetCities();
        }

        public City GetCityById(int cityId)
        {
            return _customerRepository.GetCityById(cityId);
        }

        public Comment GetCommentById(int commentId)
        {
            return _customerRepository.GetCommentById(commentId);
        }

        public List<Comment> GetComments()
        {
            return _customerRepository.GetComments();
        }

        public Core.Customer.Entities.Customer GetCustomerById(int customerId)
        {
            return _customerRepository.GetCustomerById(customerId);
        }

        public List<Core.Customer.Entities.Customer> GetCustomers()
        {
            return _customerRepository.GetCustomers();
        }

        public Province GetProvinceById(int provinceId)
        {
            return _customerRepository.GetProvinceById(provinceId);
        }

        public List<Province> GetProvinces()
        {
            return _customerRepository.GetProvinces();
        }

        public ServiceRequest GetServiceRequestById(int serviceRequestId)
        {
            return _customerRepository.GetServiceRequestById(serviceRequestId);
        }

        public List<ServiceRequest> GetServiceRequests()
        {
            return _customerRepository.GetServiceRequests();
        }

        public Address HardDeleteAddress(int addressId)
        {
            return _customerRepository.HardDeleteAddress(addressId);
        }

        public City HardDeleteCity(int cityId)
        {
            return _customerRepository.HardDeleteCity(cityId);
        }

        public Comment HardDeleteComment(int commentId)
        {
            return _customerRepository.HardDeleteComment(commentId);
        }

        public Core.Customer.Entities.Customer HardDeleteCustomer(int customerId)
        {
            return _customerRepository.HardDeleteCustomer(customerId);
        }

        public Province HardDeleteProvince(int provinceId)
        {
            return _customerRepository.HardDeleteProvince(provinceId);
        }

        public ServiceRequest HardDeleteServiceRequest(int serviceRequestId)
        {
            return _customerRepository.HardDeleteServiceRequest(serviceRequestId);
        }

        public Address SoftDeleteAddress(int addressId)
        {
            return _customerRepository.SoftDeleteAddress(addressId);
        }

        public City SoftDeleteCity(int cityId)
        {
            return _customerRepository.SoftDeleteCity(cityId);
        }

        public Comment SoftDeleteComment(int commentId)
        {
            return _customerRepository.SoftDeleteComment(commentId);
        }

        public Core.Customer.Entities.Customer SoftDeleteCustomer(int customerId)
        {
            return _customerRepository.SoftDeleteCustomer(customerId);
        }

        public Province SoftDeleteProvince(int provinceId)
        {
            return _customerRepository.SoftDeleteProvince(provinceId);
        }

        public ServiceRequest SoftDeleteServiceRequest(int serviceRequestId)
        {
            return _customerRepository.SoftDeleteServiceRequest(serviceRequestId);
        }

        public Address UpdateAddress(AddressDto addressDto)
        {
            var updatedAddress = new Address();
            updatedAddress.CreatedAt = DateTime.Now;
            updatedAddress.Street = addressDto.Street;
            updatedAddress.PostalCode = addressDto.PostalCode;
            updatedAddress.CityId = addressDto.CityId;
            return _customerRepository.UpdateAddress(updatedAddress);
        }

        public City UpdateCity(CityDto cityDto)
        {
            var updatedCity = new City();
            updatedCity.Name = cityDto.Name;
            updatedCity.ProvinceId = cityDto.ProvinceId;
            return _customerRepository.UpdateCity(updatedCity);
        }

        public Comment UpdateComment(CommentDto commentDto)
        {
            var updatedComment = new Comment();
            updatedComment.Description = commentDto.Description;
            updatedComment.Rate = commentDto.Rate;
            return _customerRepository.UpdateComment(updatedComment);
        }

        public Core.Customer.Entities.Customer UpdateCustomer(CustomerDto customerDto)
        {
            var updatedCustomer = new Core.Customer.Entities.Customer();
            updatedCustomer.FirstName = customerDto.FirstName;
            updatedCustomer.LastName = customerDto.LastName;
            updatedCustomer.PhoneNumber = customerDto.PhoneNumber;
            updatedCustomer.ProfileImage = customerDto.ProfileImage;
            return _customerRepository.UpdateCustomer(updatedCustomer);
        }

        public Province UpdateProvince(ProvinceDto provinceDto)
        {
            var updatedProvince = new Province();
            updatedProvince.Name = provinceDto.Name;
            return _customerRepository.UpdateProvince(updatedProvince);
        }

        public ServiceRequest UpdateServiceRequest(ServiceRequestDto serviceRequestDto)
        {
            var updatedServiceRequest = new ServiceRequest();
            updatedServiceRequest.CustomerDescription = serviceRequestDto.CustomerDescription;
            updatedServiceRequest.Price = serviceRequestDto.Price;
            return _customerRepository.UpdateServiceRequest(updatedServiceRequest);
        }
    }
}
