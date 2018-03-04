using System.Collections.Generic;

namespace DataLibrary.Models
{
    public interface IStore<T>
    {
        string Path { get; set; }
        List<T> GetCollection();

        T ConvertItem(string item);
    }
}