using Innovator.Client;
using System;

namespace Innovator.Client.Model
{
  ///<summary>Class for the item type Activity Transition </summary>
  public class ActivityTransition : Item
  {
    protected ActivityTransition() { }
    public ActivityTransition(ElementFactory amlContext, params object[] content) : base(amlContext, content) { }
    /// <summary>Retrieve the <c>behavior</c> property of the item</summary>
    public IProperty_Text Behavior()
    {
      return this.Property("behavior");
    }
    /// <summary>Retrieve the <c>controlled_itemtype</c> property of the item</summary>
    public IProperty_Item ControlledItemtype()
    {
      return this.Property("controlled_itemtype");
    }
    /// <summary>Retrieve the <c>event</c> property of the item</summary>
    public IProperty_Text Event()
    {
      return this.Property("event");
    }
    /// <summary>Retrieve the <c>sort_order</c> property of the item</summary>
    public IProperty_Number SortOrder()
    {
      return this.Property("sort_order");
    }
  }
}