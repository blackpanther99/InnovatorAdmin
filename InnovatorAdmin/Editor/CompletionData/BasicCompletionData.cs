﻿using ICSharpCode.AvalonEdit.CodeCompletion;
using ICSharpCode.AvalonEdit.Document;
using ICSharpCode.AvalonEdit.Editing;
using System;

namespace InnovatorAdmin.Editor
{
  public class BasicCompletionData : IMutableCompletionData
  {
    private object _content;

    public BasicCompletionData() { }
    public BasicCompletionData(string text)
    {
      this.Text = text;
    }
    public BasicCompletionData(string text, string description)
    {
      this.Text = text;
      this.Description = description;
    }

    public System.Windows.Media.ImageSource Image
    {
      get { return null; }
    }

    public Func<string> Action { get; set; }
    public virtual string Text { get; set; }

    // Use this property if you want to show a fancy UIElement in the list.
    public virtual object Content
    {
      get { return _content ?? this.Text; }
      set { _content = value; }
    }

    public object Description { get; set; }

    public virtual void Complete(TextArea textArea, ISegment completionSegment,
        EventArgs insertionRequestEventArgs)
    {
      textArea.Document.Replace(completionSegment, Action == null ? this.Text : Action.Invoke());
    }

    public double Priority
    {
      get { return 0; }
    }
  }
}