using PetaPoco;
using System.Data;
using team_nexgen.data.Interfaces.Base;
namespace team_nexgen.data.Repositories.Base {
    /// <summary>
    /// Repository
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class Repository<T> : IRepository<T> {
        /// <summary>
        /// Database
        /// </summary>
        protected Database Db;
        /// <summary>
        /// Entry Point
        /// </summary>
        public Repository() {
            Db = new Database("TeamNexgenConnectionString");
        }
        /// <summary>
        /// Repository
        /// </summary>
        /// <param name="connectionStringName"></param>
        public Repository(string connectionStringName) {
            Db = new Database(connectionStringName);
        }
        /// <summary>
        /// Repository
        /// </summary>
        /// <param name="connection"></param>
        public Repository(IDbConnection connection) {
            Db = new Database(connection);
        }
        /// <summary>
        /// Insert
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Insert(T entity) {
            Db.Insert(entity);
            return true;
        }
        /// <summary>
        /// Insert
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public T InsertReturn(T entity) {
            var obj = Db.Insert(entity);
            return entity;
        }
        /// <summary>
        /// Save (Insert or Update)
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Save(T entity) {
            Db.Save(entity);
            return true;
        }
        /// <summary>
        /// Update
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Update(T entity) {
            Db.Update(entity);
            return true;
        }
        /// <summary>
        /// Get By Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public T GetById(int id) {
            return Db.Single<T>(id);
        }
        /// <summary>
        /// Delete
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Delete(T entity) {
            return Db.Delete(entity) > 0;
        }
        /// <summary>
        /// Dispose
        /// </summary>
        public void Dispose() {
            if (Db.Connection != null) { Db.Dispose(); }
        }
    }
}