using DataLayer_POS.Interfaces;
using DataLayer_POS.Repositories;
using POS_DataModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer_POS.Services
{
    public class AdjustStockService
    {
       
            private IGenericRepository<AdjustStock> _repository = null;
            private IAdjustStockRepository _adjustStockReository = null;

            public AdjustStockService()
            {
                _repository = new GenericRepository<AdjustStock>();
                _adjustStockReository = new adjustStockRepository();
            }
           
            public List<AdjustStock> GetAllAdjustments()
            {
                var adjustStock =_adjustStockReository.GetAllAdjustments();
                return adjustStock;
            }
        public List<AdjustStock> GetAdjustmentsByDate(DateTime from,DateTime to)
        {
            var adjustStock =_adjustStockReository.GetAdjustmentsByDate(from,to);
            return adjustStock;
        }
            public AdjustStock GetById(int id)
            {
                var adjustStock = _repository.GetById(id);

                return adjustStock;
            }

            public void Insert(AdjustStock adjustStock)
            {
                _repository.Insert(adjustStock);
                _repository.Save();
            }
            public void Update(AdjustStock adjustStock)
            {
                _repository.Update(adjustStock);
                _repository.Save();
            }
            public void Delete(AdjustStock adjustStock)
            {
                _repository.Delete(adjustStock.Id);
                _repository.Save();
            }



        }
    }