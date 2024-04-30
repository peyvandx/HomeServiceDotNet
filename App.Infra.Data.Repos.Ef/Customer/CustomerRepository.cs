using App.Domain.Core.Admin.Entities;
using App.Domain.Core.Customer.Data;
using App.Domain.Core.Customer.DTOs;
using App.Domain.Core.Customer.Entities;
using App.Infra.Db.SqlServer.Ef.DbContext;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infra.Data.Repos.Ef.Customer
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly HomeServiceDbContext _homeServiceDbContext;

        public CustomerRepository(HomeServiceDbContext homeServiceDbContext)
        {
            _homeServiceDbContext = homeServiceDbContext;
        }

        public Address CreateAddress(Address submittedAddress)
        {
            _homeServiceDbContext.Addresses.Add(submittedAddress);
            _homeServiceDbContext.SaveChanges();
            return submittedAddress;
        }

        public City CreateCity(City submittedCity)
        {
            _homeServiceDbContext.Cities.Add(submittedCity);
            _homeServiceDbContext.SaveChanges();
            return submittedCity;
        }

        public Comment CreateComment(Comment submittedComment)
        {
            _homeServiceDbContext.Comments.Add(submittedComment);
            _homeServiceDbContext.SaveChanges();
            return submittedComment;
        }

        public Domain.Core.Customer.Entities.Customer CreateCustomer(Domain.Core.Customer.Entities.Customer signingUpCustomer)
        {
            _homeServiceDbContext.Customers.Add(signingUpCustomer);
            _homeServiceDbContext.SaveChanges();
            return signingUpCustomer;
        }

        public Province CreateProvince(Province submittedProvince)
        {
            _homeServiceDbContext.Provinces.Add(submittedProvince);
            _homeServiceDbContext.SaveChanges();
            return submittedProvince;
        }

        public ServiceRequest CreateServiceRequest(ServiceRequest submittedServiceRequest)
        {
            _homeServiceDbContext.ServiceRequests.Add(submittedServiceRequest);
            _homeServiceDbContext.SaveChanges();
            return submittedServiceRequest;
        }

        public Address GetAddressById(int addressId)
        {
            return _homeServiceDbContext.Addresses.FirstOrDefault(a => a.Id == addressId);
        }

        public List<Address> GetAddresses()
        {
            return _homeServiceDbContext.Addresses.ToList();
        }

        public List<City> GetCities()
        {
            return _homeServiceDbContext.Cities.ToList();
        }

        public City GetCityById(int cityId)
        {
            return _homeServiceDbContext.Cities.FirstOrDefault(c => c.Id == cityId);
        }

        public Comment GetCommentById(int commentId)
        {
            return _homeServiceDbContext.Comments.FirstOrDefault(c => c.Id == commentId);
        }

        public List<Comment> GetComments()
        {
            return _homeServiceDbContext.Comments.ToList();
        }

        public Domain.Core.Customer.Entities.Customer GetCustomerById(int customerId)
        {
            return _homeServiceDbContext.Customers.FirstOrDefault(c => c.Id == customerId);
        }

        public List<Domain.Core.Customer.Entities.Customer> GetCustomers()
        {
            return _homeServiceDbContext.Customers.ToList();
        }

        public Province GetProvinceById(int provinceId)
        {
            return _homeServiceDbContext.Provinces.FirstOrDefault(p => p.Id == provinceId);
        }

        public List<Province> GetProvinces()
        {
            return _homeServiceDbContext.Provinces.ToList();
        }

        public ServiceRequest GetServiceRequestById(int serviceRequestId)
        {
            return _homeServiceDbContext.ServiceRequests.FirstOrDefault(sr => sr.Id == serviceRequestId);
        }

        public List<ServiceRequest> GetServiceRequests()
        {
            return _homeServiceDbContext.ServiceRequests.ToList();
        }

        public Address HardDeleteAddress(int addressId)
        {
            var deletedAddress = GetAddressById(addressId);
            if (deletedAddress != null)
            {
                deletedAddress.IsDeleted = true;
                _homeServiceDbContext.Addresses.Remove(deletedAddress);
                _homeServiceDbContext.SaveChanges();
                return deletedAddress;
            }
            else
            {
                //throw an exception - will be implement!
                throw new InvalidOperationException();
            }
        }

        public City HardDeleteCity(int cityId)
        {
            var deletedCity = GetCityById(cityId);
            if (deletedCity != null)
            {
                deletedCity.IsDeleted = true;
                _homeServiceDbContext.Cities.Remove(deletedCity);
                _homeServiceDbContext.SaveChanges();
                return deletedCity;
            }
            else
            {
                //throw an exception - will be implement!
                throw new InvalidOperationException();
            }
        }

        public Comment HardDeleteComment(int commentId)
        {
            var deletedComment = GetCommentById(commentId);
            if (deletedComment != null)
            {
                deletedComment.IsDeleted = true;
                _homeServiceDbContext.Comments.Remove(deletedComment);
                _homeServiceDbContext.SaveChanges();
                return deletedComment;
            }
            else
            {
                //throw an exception - will be implement!
                throw new InvalidOperationException();
            }
        }

        public Domain.Core.Customer.Entities.Customer HardDeleteCustomer(int customerId)
        {
            var deletedCustomer = GetCustomerById(customerId);
            if (deletedCustomer != null)
            {
                deletedCustomer.IsDeleted = true;
                _homeServiceDbContext.Customers.Remove(deletedCustomer);
                _homeServiceDbContext.SaveChanges();
                return deletedCustomer;
            }
            else
            {
                //throw an exception - will be implement!
                throw new InvalidOperationException();
            }
        }

        public Province HardDeleteProvince(int provinceId)
        {
            var deletedProvince = GetProvinceById(provinceId);
            if (deletedProvince != null)
            {
                deletedProvince.IsDeleted = true;
                _homeServiceDbContext.Provinces.Remove(deletedProvince);
                _homeServiceDbContext.SaveChanges();
                return deletedProvince;
            }
            else
            {
                //throw an exception - will be implement!
                throw new InvalidOperationException();
            }
        }

        public ServiceRequest HardDeleteServiceRequest(int serviceRequestId)
        {
            var deletedServiceRequest = GetServiceRequestById(serviceRequestId);
            if (deletedServiceRequest != null)
            {
                deletedServiceRequest.IsDeleted = true;
                _homeServiceDbContext.ServiceRequests.Remove(deletedServiceRequest);
                _homeServiceDbContext.SaveChanges();
                return deletedServiceRequest;
            }
            else
            {
                //throw an exception - will be implement!
                throw new InvalidOperationException();
            }
        }

        public Address SoftDeleteAddress(int addressId)
        {
            var deletedAddress = GetAddressById(addressId);
            if (deletedAddress != null)
            {
                deletedAddress.IsDeleted = true;
                _homeServiceDbContext.SaveChanges();
                return deletedAddress;
            }
            else
            {
                //throw an exception - will be implement!
                throw new InvalidOperationException();
            }
        }

        public City SoftDeleteCity(int cityId)
        {
            var deletedCity = GetCityById(cityId);
            if (deletedCity != null)
            {
                deletedCity.IsDeleted = true;
                _homeServiceDbContext.SaveChanges();
                return deletedCity;
            }
            else
            {
                //throw an exception - will be implement!
                throw new InvalidOperationException();
            }
        }

        public Comment SoftDeleteComment(int commentId)
        {
            var deletedComment = GetCommentById(commentId);
            if (deletedComment != null)
            {
                deletedComment.IsDeleted = true;
                _homeServiceDbContext.SaveChanges();
                return deletedComment;
            }
            else
            {
                //throw an exception - will be implement!
                throw new InvalidOperationException();
            }
        }

        public Domain.Core.Customer.Entities.Customer SoftDeleteCustomer(int customerId)
        {
            var deletedCustomer = GetCustomerById(customerId);
            if (deletedCustomer != null)
            {
                deletedCustomer.IsDeleted = true;
                _homeServiceDbContext.SaveChanges();
                return deletedCustomer;
            }
            else
            {
                //throw an exception - will be implement!
                throw new InvalidOperationException();
            }
        }

        public Province SoftDeleteProvince(int provinceId)
        {
            var deletedProvince = GetProvinceById(provinceId);
            if (deletedProvince != null)
            {
                deletedProvince.IsDeleted = true;
                _homeServiceDbContext.SaveChanges();
                return deletedProvince;
            }
            else
            {
                //throw an exception - will be implement!
                throw new InvalidOperationException();
            }
        }

        public ServiceRequest SoftDeleteServiceRequest(int serviceRequestId)
        {
            var deletedServiceRequest = GetServiceRequestById(serviceRequestId);
            if (deletedServiceRequest != null)
            {
                deletedServiceRequest.IsDeleted = true;
                _homeServiceDbContext.SaveChanges();
                return deletedServiceRequest;
            }
            else
            {
                //throw an exception - will be implement!
                throw new InvalidOperationException();
            }
        }

        public Address UpdateAddress(Address updatedAddress)
        {
            var updatingAddress = GetAddressById(updatedAddress.Id);
            if (updatingAddress != null)
            {
                updatingAddress.Street = updatedAddress.Street;
                updatingAddress.PostalCode = updatedAddress.PostalCode;
                updatingAddress.CityId = updatedAddress.CityId;
                _homeServiceDbContext.SaveChanges();
                return updatingAddress;
            }
            else
            {
                //throw an exception - will be implement!
                throw new InvalidOperationException();
            }
        }

        public City UpdateCity(City updatedCity)
        {
            var updatingCity = GetCityById(updatedCity.Id);
            if(updatingCity != null)
            {
                updatingCity.Name = updatedCity.Name;
                updatingCity.ProvinceId = updatedCity.ProvinceId;
                _homeServiceDbContext.SaveChanges();
                return updatingCity;
            }
            else
            {
                //throw an exception - will be implement!
                throw new InvalidOperationException();
            }
        }

        public Comment UpdateComment(Comment updatedComment)
        {
            var updatingComment = GetCommentById(updatedComment.Id);
            if (updatingComment != null)
            {
                updatingComment.Description = updatedComment.Description;
                updatingComment.Rate = updatedComment.Rate;
                _homeServiceDbContext.SaveChanges();
                return updatingComment;
            }
            else
            {
                //throw an exception - will be implement!
                throw new InvalidOperationException();
            }
        }

        public Domain.Core.Customer.Entities.Customer UpdateCustomer(Domain.Core.Customer.Entities.Customer updatedCustomer)
        {
            var updatingCustomer = GetCustomerById(updatedCustomer.Id);
            if (updatingCustomer != null)
            {
                updatingCustomer.FirstName = updatedCustomer.FirstName;
                updatingCustomer.LastName = updatingCustomer.LastName;
                updatingCustomer.PhoneNumber = updatedCustomer.PhoneNumber;
                updatingCustomer.ProfileImage = updatedCustomer.ProfileImage;
                _homeServiceDbContext.SaveChanges();
                return updatingCustomer;
            }
            else
            {
                //throw an exception - will be implement!
                throw new InvalidOperationException();
            }
        }

        public Province UpdateProvince(Province updatedProvince)
        {
            var updatingProvince = GetProvinceById(updatedProvince.Id);
            if (updatingProvince != null)
            {
                updatingProvince.Name = updatedProvince.Name;
                _homeServiceDbContext.SaveChanges();
                return updatingProvince;
            }
            else
            {
                //throw an exception - will be implement!
                throw new InvalidOperationException();
            }
        }

        public ServiceRequest UpdateServiceRequest(ServiceRequest updatedServiceRequest)
        {
            var updatingServiceRequest = GetServiceRequestById(updatedServiceRequest.Id);
            if (updatingServiceRequest != null)
            {
                updatingServiceRequest.CustomerDescription = updatedServiceRequest.CustomerDescription;
                updatingServiceRequest.Price = updatedServiceRequest.Price;
                _homeServiceDbContext.SaveChanges();
                return updatingServiceRequest;
            }
            else
            {
                //throw an exception - will be implement!
                throw new InvalidOperationException();
            }
        }
    }
}
