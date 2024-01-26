using System;
namespace uteq.Core
{
	public interface ICommand
	{
		void Execute(object? parameter);
		bool CanExecute(object? parameter);
	}
}

