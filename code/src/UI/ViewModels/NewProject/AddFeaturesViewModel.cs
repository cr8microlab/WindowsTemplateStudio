﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.ObjectModel;
using Microsoft.Templates.Core;
using Microsoft.Templates.Core.Mvvm;
using Microsoft.Templates.UI.Services;
using Microsoft.Templates.UI.ViewModels.Common;

namespace Microsoft.Templates.UI.ViewModels.NewProject
{
    public class AddFeaturesViewModel : Observable
    {
        public ObservableCollection<TemplateGroupViewModel> Groups { get; } = new ObservableCollection<TemplateGroupViewModel>();

        public AddFeaturesViewModel()
        {
        }

        public void LoadData(string frameworkName)
        {
            Groups.Clear();
            DataService.LoadTemplateGroups(Groups, TemplateType.Feature, frameworkName);
        }

        public void ResetTemplatesCount()
        {
            foreach (var group in Groups)
            {
                foreach (var template in group.Items)
                {
                    template.ResetTemplateCount();
                }
            }
        }
    }
}
