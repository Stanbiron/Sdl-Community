﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sdl.Community.SdlTmAnonymizer.Helpers;
using Sdl.Community.SdlTmAnonymizer.Model;
using Sdl.Community.SdlTmAnonymizer.ViewModel;
using Sdl.Community.TmAnonymizer.Model;
using Sdl.LanguagePlatform.TranslationMemory;
using Sdl.LanguagePlatform.TranslationMemoryApi;

namespace Sdl.Community.TmAnonymizer.ViewModel
{
	public class CustomFieldsViewModel : ViewModelBase
	{
		private static TranslationMemoryViewModel _translationMemoryViewModel;
		private ObservableCollection<CustomField> _customFields = new ObservableCollection<CustomField>();


		public CustomFieldsViewModel(TranslationMemoryViewModel translationMemoryViewModel)
		{
		//	var tm =
		//	new FileBasedTranslationMemory(@"C:\Users\aghisa\Desktop\cy-en_(Fields_and_Attributes).sdltm");

		//_customFields = new ObservableCollection<CustomField>(CustomFieldsHandler.GetCustomField(tm));
			_translationMemoryViewModel = translationMemoryViewModel;

		}

		public ObservableCollection<CustomField> CustomFieldsCollection
		{
			get => _customFields;

			set
			{
				if (Equals(value, _customFields))
				{
					return;
				}
				_customFields = value;
				OnPropertyChanged(nameof(CustomFieldsCollection));

			}
		}
	}
}



