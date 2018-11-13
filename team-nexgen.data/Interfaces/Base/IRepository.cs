namespace team_nexgen.data.Interfaces.Base {
    /// <summary>
    /// IRepository
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRepository<T> {
        /// <summary>
        /// Insert
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        bool Insert(T entity);
        /// <summary>
        /// Insert Return
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        T InsertReturn(T entity);
        /// <summary>
        /// Save (Insert or Update)
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        bool Save(T entity);
        /// <summary>
        /// Update
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        bool Update(T entity);
        /// <summary>
        /// Get By Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        T GetById(int id);
        /// <summary>
        /// Delete
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        bool Delete(T entity);
        /// <summary>
        /// Dispose
        /// </summary>
        void Dispose();
    }
}