﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeProjeto.ViewModels;

namespace YoutubeProjeto.Stores;
public class ModalNavigationStore
{
	private ViewModelBase _currentViewModel;

	public ViewModelBase CurrentViewModel
	{
		get { return _currentViewModel; }
		set { _currentViewModel = value;
			CurrentViewModelChanged?.Invoke();

        }
	}
	public event Action CurrentViewModelChanged;
}
