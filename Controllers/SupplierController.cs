using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BookHaven.Models.Services;
using BookHeaven.Models.Entity;

namespace BookHaven.Controllers
{
    public class SupplierController
    {
        private readonly SupplierService _supplierService;

        public SupplierController(SupplierService supplierService)
        {
            _supplierService = supplierService;
        }

        // Get a supplier by their ID
        public async Task<Supplier?> GetSupplierById(Guid supplierId)
        {
            return await _supplierService.GetSupplierByIdAsync(supplierId);
        }

        // Get all suppliers
        public async Task<List<Supplier>> GetAllSuppliers()
        {
            return (List<Supplier>)await _supplierService.GetAllSuppliersAsync();
        }

        // Create a new supplier
        public async Task<bool> CreateSupplier(Supplier supplier)
        {
            try
            {
                await _supplierService.CreateSupplierAsync(supplier);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating supplier: {ex.Message}");
                return false;
            }
        }

        // Update an existing supplier
        public async Task<bool> UpdateSupplier(Supplier supplier)
        {
            try
            {
                await _supplierService.UpdateSupplierAsync(supplier);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating supplier: {ex.Message}");
                return false;
            }
        }

        // Delete a supplier by their ID
        public async Task<bool> DeleteSupplier(Guid supplierId)
        {
            try
            {
                await _supplierService.DeleteSupplierAsync(supplierId);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting supplier: {ex.Message}");
                return false;
            }
        }

        // Get all orders for a specific supplier by their ID
        public async Task<List<SupplierOrder>> GetOrdersBySupplierId(Guid supplierId)
        {
            return (List<SupplierOrder>)await _supplierService.GetOrdersBySupplierIdAsync(supplierId);
        }

        // Get suppliers by their name
        public async Task<List<Supplier>> GetSuppliersByName(string name)
        {
            return (List<Supplier>)await _supplierService.GetSuppliersByNameAsync(name);
        }

        // Get suppliers by their contact information
        public async Task<List<Supplier>> GetSuppliersByContactInfo(string contactInfo)
        {
            return (List<Supplier>)await _supplierService.GetSuppliersByContactInfoAsync(contactInfo);
        }

        // Get all orders for a specific supplier by their ID and order status
        public async Task<List<SupplierOrder>> GetOrdersByStatus(Guid supplierId, string status)
        {
            return (List<SupplierOrder>)await _supplierService.GetOrdersByStatusAsync(supplierId, status);
        }
    }
}
