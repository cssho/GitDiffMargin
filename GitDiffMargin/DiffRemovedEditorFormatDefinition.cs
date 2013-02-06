﻿using GitDiffMargin.Git;
using System.ComponentModel.Composition;
using System.Windows.Media;
using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Utilities;

namespace GitDiffMargin
{
    [Export(typeof(EditorFormatDefinition))]
    [Name(DiffFormatNames.Removed)]
    [UserVisible(true)]
    internal sealed class DiffRemovedEditorFormatDefinition : EditorFormatDefinition
    {
        public DiffRemovedEditorFormatDefinition()
        {
            BackgroundColor = Color.FromRgb(255, 160, 180);
            ForegroundCustomizable = false;
            DisplayName = "Git Diff Removed";
        }
    }
}