﻿
namespace WebApp.DataTransferObject.Helpers
{
    public class BaseTreeDto<TTree, TKey>
        where TTree : BaseTreeDto<TTree, TKey>
        where TKey: IEquatable<TKey>
    {
        public virtual TKey Id { get; set; }
        public virtual TKey ParentId { get; set; }
        public virtual List<TTree> Children { get; set; }


        public static async Task<List<TTree>> ToTreeAsync(List<TTree> lTreeDtos)
        {
            var treeDictionary = new Dictionary<TKey?, TTree>();

            lTreeDtos.ForEach(x => treeDictionary.Add(x.Id, x));

            foreach (var item in treeDictionary.Values)
            {
                if (item.ParentId != null)
                {
                    TTree proposedParent;
                    if (treeDictionary.TryGetValue(item.ParentId, out proposedParent))
                    {
                        if (proposedParent.Children is null)
                            proposedParent.Children = new List<TTree>();

                        proposedParent.Children.Add(item);
                    }
                }
            }
            return treeDictionary.Values.Where(x => x.ParentId == null).ToList();
        }
    }


}
