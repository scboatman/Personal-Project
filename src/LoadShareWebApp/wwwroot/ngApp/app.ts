namespace LoadShareWebApp {

    angular.module('LoadShareWebApp', ['ui.router', 'ngResource', 'ui.bootstrap']).config((
        $stateProvider: ng.ui.IStateProvider,
        $urlRouterProvider: ng.ui.IUrlRouterProvider,
        $locationProvider: ng.ILocationProvider
    ) => {
        // Define routes
        $stateProvider
            .state('home', {
                url: '/',
                templateUrl: '/ngApp/views/home.html',
                controller: LoadShareWebApp.Controllers.HomeController,
                controllerAs: 'c'
            })
            .state('trucks', {
                url: '/trucks',
                templateUrl: '/ngApp/views/trucks.html',
                controller: LoadShareWebApp.Controllers.TruckController,
                controllerAs: 'c'
            })
            .state('loads', {
                url: '/loads',
                templateUrl: '/ngApp/views/loads.html',
                controller: LoadShareWebApp.Controllers.LoadController,
                controllerAs: 'c'
            })
            .state('truckdetails', {
                url: '/truckdetails',
                templateUrl: '/ngApp/views/truckdetails.html',
                controller: LoadShareWebApp.Controllers.TruckDetailController,
                controllerAs: 'c'
        })

        // Handle request for non-existent route
        $urlRouterProvider.otherwise('/notFound');

        // Enable HTML5 navigation
        $locationProvider.html5Mode(true);
    });

    

}
