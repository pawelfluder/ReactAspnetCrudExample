using Threenine.Data.Paging;

namespace SharpRepositoryServiceProg
{
    public class Paginate<T> : IPaginate<T>
    {
        private IQueryable<T> querable;

        public Paginate(IQueryable<T> itemsList)
        {
            querable = itemsList;
        }

        public IList<T> Items => querable.ToList();

        public int From => throw new NotImplementedException();

        public int Index => throw new NotImplementedException();

        public int Size => throw new NotImplementedException();

        public int Count => throw new NotImplementedException();

        public int Pages => throw new NotImplementedException();

        public bool HasPrevious => throw new NotImplementedException();

        public bool HasNext => throw new NotImplementedException();
    }
}
