# Important

Issues of this repository are tracked on https://github.com/aspnetboilerplate/aspnetboilerplate. Please create your issues on https://github.com/aspnetboilerplate/aspnetboilerplate/issues.

# Environment

ABP 6.5.0 + ASP.NET Core 5.0 (.NET 5.0)

Project created from template https://aspnetboilerplate.com/Templates.

# Issue

Microsoft.AspNetCore.Hosting.WebHost: Critical: Application startup exception

Castle.MicroKernel.ComponentActivator.ComponentActivatorException: ComponentActivator: could not instantiate AcmeDemo.EntityFrameworkCore.Repositories.AcmeDemoRepositoryBase`1[[Abp.Localization.ApplicationLanguage, Abp.Zero.Common, Version=6.5.0.0, Culture=neutral, PublicKeyToken=null]]
 ---> System.ArgumentException: Type AcmeDemo.EntityFrameworkCore.Repositories.AcmeDemoRepositoryBase`1[[Abp.Localization.ApplicationLanguage, Abp.Zero.Common, Version=6.5.0.0, Culture=neutral, PublicKeyToken=null]] does not have a public default constructor and could not be instantiated.
 ---> System.MissingMethodException: Constructor on type 'AcmeDemo.EntityFrameworkCore.Repositories.AcmeDemoRepositoryBase`1[[Abp.Localization.ApplicationLanguage, Abp.Zero.Common, Version=6.5.0.0, Culture=neutral, PublicKeyToken=null]]' not found.
   at System.RuntimeType.CreateInstanceImpl(BindingFlags bindingAttr, Binder binder, Object[] args, CultureInfo culture)
   at Castle.Core.Internal.ReflectionUtil.Instantiate[TBase](Type subtypeofTBase, Object[] ctorArgs)
   --- End of inner exception stack trace ---
   at Castle.Core.Internal.ReflectionUtil.Instantiate[TBase](Type subtypeofTBase, Object[] ctorArgs)
   at Castle.MicroKernel.ComponentActivator.DefaultComponentActivator.CreateInstanceCore(ConstructorCandidate constructor, Object[] arguments, Type implType)
   --- End of inner exception stack trace ---
   at Castle.MicroKernel.ComponentActivator.DefaultComponentActivator.CreateInstanceCore(ConstructorCandidate constructor, Object[] arguments, Type implType)
   at Castle.MicroKernel.ComponentActivator.DefaultComponentActivator.CreateInstance(CreationContext context, ConstructorCandidate constructor, Object[] arguments)
   at Castle.MicroKernel.ComponentActivator.DefaultComponentActivator.Instantiate(CreationContext context)
   at Castle.MicroKernel.ComponentActivator.DefaultComponentActivator.InternalCreate(CreationContext context)
   at Castle.MicroKernel.ComponentActivator.AbstractComponentActivator.Create(CreationContext context, Burden burden)
   at Castle.MicroKernel.Lifestyle.AbstractLifestyleManager.CreateInstance(CreationContext context, Boolean trackedExternally)
   at Castle.MicroKernel.Lifestyle.AbstractLifestyleManager.Resolve(CreationContext context, IReleasePolicy releasePolicy)
   at Castle.MicroKernel.Handlers.DefaultHandler.ResolveCore(CreationContext context, Boolean requiresDecommission, Boolean instanceRequired, Burden& burden)
   at Castle.MicroKernel.Handlers.DefaultHandler.Resolve(CreationContext context, Boolean instanceRequired)
   at Castle.MicroKernel.Handlers.AbstractHandler.Resolve(CreationContext context)
   at Castle.MicroKernel.Resolvers.DefaultDependencyResolver.ResolveFromKernelByType(CreationContext context, ComponentModel model, DependencyModel dependency)
   at Castle.MicroKernel.Resolvers.DefaultDependencyResolver.ResolveFromKernel(CreationContext context, ComponentModel model, DependencyModel dependency)
   at Castle.MicroKernel.Resolvers.DefaultDependencyResolver.TryResolveCore(CreationContext context, ISubDependencyResolver contextHandlerResolver, ComponentModel model, DependencyModel dependency, Object& value)
   at Castle.MicroKernel.Resolvers.DefaultDependencyResolver.Resolve(CreationContext context, ISubDependencyResolver contextHandlerResolver, ComponentModel model, DependencyModel dependency)
   at Castle.MicroKernel.ComponentActivator.DefaultComponentActivator.CreateConstructorArguments(ConstructorCandidate constructor, CreationContext context)
   at Castle.MicroKernel.ComponentActivator.DefaultComponentActivator.Instantiate(CreationContext context)
   at Castle.MicroKernel.ComponentActivator.DefaultComponentActivator.InternalCreate(CreationContext context)
   at Castle.MicroKernel.ComponentActivator.AbstractComponentActivator.Create(CreationContext context, Burden burden)
   at Castle.MicroKernel.Lifestyle.AbstractLifestyleManager.CreateInstance(CreationContext context, Boolean trackedExternally)
   at Castle.MicroKernel.Lifestyle.SingletonLifestyleManager.Resolve(CreationContext context, IReleasePolicy releasePolicy)
   at Castle.MicroKernel.Handlers.DefaultHandler.ResolveCore(CreationContext context, Boolean requiresDecommission, Boolean instanceRequired, Burden& burden)
   at Castle.MicroKernel.Handlers.DefaultHandler.Resolve(CreationContext context, Boolean instanceRequired)
   at Castle.MicroKernel.Handlers.AbstractHandler.Resolve(CreationContext context)
   at Castle.MicroKernel.Resolvers.DefaultDependencyResolver.ResolveFromKernelByType(CreationContext context, ComponentModel model, DependencyModel dependency)
   at Castle.MicroKernel.Resolvers.DefaultDependencyResolver.ResolveFromKernel(CreationContext context, ComponentModel model, DependencyModel dependency)
   at Castle.MicroKernel.Resolvers.DefaultDependencyResolver.TryResolveCore(CreationContext context, ISubDependencyResolver contextHandlerResolver, ComponentModel model, DependencyModel dependency, Object& value)
   at Castle.MicroKernel.Resolvers.DefaultDependencyResolver.Resolve(CreationContext context, ISubDependencyResolver contextHandlerResolver, ComponentModel model, DependencyModel dependency)
   at Castle.MicroKernel.ComponentActivator.DefaultComponentActivator.CreateConstructorArguments(ConstructorCandidate constructor, CreationContext context)
   at Castle.MicroKernel.ComponentActivator.DefaultComponentActivator.Instantiate(CreationContext context)
   at Castle.MicroKernel.ComponentActivator.DefaultComponentActivator.InternalCreate(CreationContext context)
   at Castle.MicroKernel.ComponentActivator.AbstractComponentActivator.Create(CreationContext context, Burden burden)
   at Castle.MicroKernel.Lifestyle.AbstractLifestyleManager.CreateInstance(CreationContext context, Boolean trackedExternally)
   at Castle.MicroKernel.Lifestyle.AbstractLifestyleManager.Resolve(CreationContext context, IReleasePolicy releasePolicy)
   at Castle.MicroKernel.Handlers.DefaultHandler.ResolveCore(CreationContext context, Boolean requiresDecommission, Boolean instanceRequired, Burden& burden)
   at Castle.MicroKernel.Handlers.DefaultHandler.Resolve(CreationContext context, Boolean instanceRequired)
   at Castle.MicroKernel.Handlers.AbstractHandler.Resolve(CreationContext context)
   at Castle.MicroKernel.Resolvers.DefaultDependencyResolver.ResolveFromKernelByType(CreationContext context, ComponentModel model, DependencyModel dependency)
   at Castle.MicroKernel.Resolvers.DefaultDependencyResolver.ResolveFromKernel(CreationContext context, ComponentModel model, DependencyModel dependency)
   at Castle.MicroKernel.Resolvers.DefaultDependencyResolver.TryResolveCore(CreationContext context, ISubDependencyResolver contextHandlerResolver, ComponentModel model, DependencyModel dependency, Object& value)
   at Castle.MicroKernel.Resolvers.DefaultDependencyResolver.Resolve(CreationContext context, ISubDependencyResolver contextHandlerResolver, ComponentModel model, DependencyModel dependency)
   at Castle.MicroKernel.ComponentActivator.DefaultComponentActivator.CreateConstructorArguments(ConstructorCandidate constructor, CreationContext context)
   at Castle.MicroKernel.ComponentActivator.DefaultComponentActivator.Instantiate(CreationContext context)
   at Castle.MicroKernel.ComponentActivator.DefaultComponentActivator.InternalCreate(CreationContext context)
   at Castle.MicroKernel.ComponentActivator.AbstractComponentActivator.Create(CreationContext context, Burden burden)
   at Castle.MicroKernel.Lifestyle.AbstractLifestyleManager.CreateInstance(CreationContext context, Boolean trackedExternally)
   at Castle.MicroKernel.Lifestyle.AbstractLifestyleManager.Resolve(CreationContext context, IReleasePolicy releasePolicy)
   at Castle.MicroKernel.Handlers.DefaultHandler.ResolveCore(CreationContext context, Boolean requiresDecommission, Boolean instanceRequired, Burden& burden)
   at Castle.MicroKernel.Handlers.DefaultHandler.Resolve(CreationContext context, Boolean instanceRequired)
   at Castle.MicroKernel.Handlers.AbstractHandler.Resolve(CreationContext context)
   at Castle.MicroKernel.Resolvers.DefaultDependencyResolver.ResolveFromKernelByType(CreationContext context, ComponentModel model, DependencyModel dependency)
   at Castle.MicroKernel.Resolvers.DefaultDependencyResolver.ResolveFromKernel(CreationContext context, ComponentModel model, DependencyModel dependency)
   at Castle.MicroKernel.Resolvers.DefaultDependencyResolver.TryResolveCore(CreationContext context, ISubDependencyResolver contextHandlerResolver, ComponentModel model, DependencyModel dependency, Object& value)
   at Castle.MicroKernel.Resolvers.DefaultDependencyResolver.Resolve(CreationContext context, ISubDependencyResolver contextHandlerResolver, ComponentModel model, DependencyModel dependency)
   at Castle.MicroKernel.ComponentActivator.DefaultComponentActivator.CreateConstructorArguments(ConstructorCandidate constructor, CreationContext context)
   at Castle.MicroKernel.ComponentActivator.DefaultComponentActivator.Instantiate(CreationContext context)
   at Castle.MicroKernel.ComponentActivator.DefaultComponentActivator.InternalCreate(CreationContext context)
   at Castle.MicroKernel.ComponentActivator.AbstractComponentActivator.Create(CreationContext context, Burden burden)
   at Castle.MicroKernel.Lifestyle.AbstractLifestyleManager.CreateInstance(CreationContext context, Boolean trackedExternally)
   at Castle.MicroKernel.Lifestyle.SingletonLifestyleManager.Resolve(CreationContext context, IReleasePolicy releasePolicy)
   at Castle.MicroKernel.Handlers.DefaultHandler.ResolveCore(CreationContext context, Boolean requiresDecommission, Boolean instanceRequired, Burden& burden)
   at Castle.MicroKernel.Handlers.DefaultHandler.Resolve(CreationContext context, Boolean instanceRequired)
   at Castle.MicroKernel.Handlers.AbstractHandler.Resolve(CreationContext context)
   at Castle.MicroKernel.DefaultKernel.ResolveComponent(IHandler handler, Type service, Arguments additionalArguments, IReleasePolicy policy, Boolean ignoreParentContext)
   at Castle.MicroKernel.DefaultKernel.Castle.MicroKernel.IKernelInternal.Resolve(Type service, Arguments arguments, IReleasePolicy policy, Boolean ignoreParentContext)
   at Castle.MicroKernel.DefaultKernel.Resolve(Type service, Arguments arguments)
   at Castle.Windsor.WindsorContainer.Resolve[T]()
   at Abp.Dependency.IocManager.Resolve[T]()
   at Abp.AbpKernelModule.PostInitialize()
   at Abp.Modules.AbpModuleManager.<>c.<StartModules>b__15_2(AbpModuleInfo module)
   at System.Collections.Generic.List`1.ForEach(Action`1 action)
   at Abp.Modules.AbpModuleManager.StartModules()
   at Abp.AbpBootstrapper.Initialize()
   at Abp.AspNetCore.AbpApplicationBuilderExtensions.InitializeAbp(IApplicationBuilder app)
   at Abp.AspNetCore.AbpApplicationBuilderExtensions.UseAbp(IApplicationBuilder app, Action`1 optionsAction)
   at Abp.AspNetCore.AbpApplicationBuilderExtensions.UseAbp(IApplicationBuilder app)
   at AcmeDemo.Web.Startup.Startup.Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory) in E:\AcmeDemo\aspnet-core\src\AcmeDemo.Web.Mvc\Startup\Startup.cs:line 77
   at System.RuntimeMethodHandle.InvokeMethod(Object target, Object[] arguments, Signature sig, Boolean constructor, Boolean wrapExceptions)
   at System.Reflection.RuntimeMethodInfo.Invoke(Object obj, BindingFlags invokeAttr, Binder binder, Object[] parameters, CultureInfo culture)
   at Microsoft.AspNetCore.Hosting.ConfigureBuilder.Invoke(Object instance, IApplicationBuilder builder)
   at Microsoft.AspNetCore.Hosting.ConfigureBuilder.<>c__DisplayClass4_0.<Build>b__0(IApplicationBuilder builder)
   at Microsoft.AspNetCore.Hosting.ConventionBasedStartup.Configure(IApplicationBuilder app)
   at Microsoft.AspNetCore.Mvc.Filters.MiddlewareFilterBuilderStartupFilter.<>c__DisplayClass0_0.<Configure>g__MiddlewareFilterBuilder|0(IApplicationBuilder builder)
   at Microsoft.AspNetCore.HostFilteringStartupFilter.<>c__DisplayClass0_0.<Configure>b__0(IApplicationBuilder app)
   at Microsoft.AspNetCore.Hosting.WebHost.BuildApplication()
Exception thrown: 'Castle.MicroKernel.ComponentActivator.ComponentActivatorException' in Microsoft.AspNetCore.Hosting.dll
Exception thrown: 'Castle.MicroKernel.ComponentActivator.ComponentActivatorException' in System.Private.CoreLib.dll
Exception thrown: 'System.OperationCanceledException' in System.Private.CoreLib.dll
Exception thrown: 'System.OperationCanceledException' in System.Private.CoreLib.dll
The thread 0x28b4 has exited with code 0 (0x0).
Exception thrown: 'Castle.MicroKernel.ComponentActivator.ComponentActivatorException' in System.Private.CoreLib.dll
Exception thrown: 'Castle.MicroKernel.ComponentActivator.ComponentActivatorException' in System.Private.CoreLib.dll
Exception thrown: 'Castle.MicroKernel.ComponentActivator.ComponentActivatorException' in System.Private.CoreLib.dll
An unhandled exception of type 'Castle.MicroKernel.ComponentActivator.ComponentActivatorException' occurred in System.Private.CoreLib.dll
ComponentActivator: could not instantiate AcmeDemo.EntityFrameworkCore.Repositories.AcmeDemoRepositoryBase`1[[Abp.Localization.ApplicationLanguage, Abp.Zero.Common, Version=6.5.0.0, Culture=neutral, PublicKeyToken=null]]
