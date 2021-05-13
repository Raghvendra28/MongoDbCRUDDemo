using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MongoDbCRUD.DataAccess.Interface
{
    public interface IMongoCRUD<T> where T : class
    {
        ///<summary>  
        /// Generic add method to insert enities to collection   
        ///</summary>  
        ///<param name="entity"></param> 
        Task Add(T entity);

        ///<summary>  
        /// Generic Get method to get all records   
        ///</summary>  
        ///<returns></returns> 
        Task<List<T>> GetAll();

        /// <summary>
        /// Generic Get method to get record on the basis of id  
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<T> Get(Guid id);

        /// <summary>
        /// Generic update method to delete record on the basis of id
        /// </summary>
        /// <param name="queryExpression"></param>
        /// <param name="id"></param>
        /// <param name="entity"></param>
        Task Update(Guid id, T entity);

        /// <summary>
        /// Generic delete method to delete record on the basis of id
        /// </summary>
        /// <param name="queryExpression"></param>
        /// <param name="id"></param>
        Task Delete(Guid id);
    }
}
