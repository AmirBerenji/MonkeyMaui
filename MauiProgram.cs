﻿using Microsoft.Extensions.Logging;
using TestProject.Services;
using TestProject.ViewModels;

namespace TestProject;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		builder.Services.AddSingleton<MonkeyService>();

		builder.Services.AddSingleton<MonkeysViewModel>();
        builder.Services.AddTransient<MonkeyDetailsViewModel>();

        builder.Services.AddSingleton<MainPage>();
        builder.Services.AddTransient<DetailsPage>(); 
#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
