
var app = angular.module('app', ['ngRoute']);

app.config(function ($routeProvider) {
    $routeProvider
        .when('/', {
            templateUrl: '/app/Home/home.html?version=1'
        })
        .when('/services/:id', {
            templateUrl: '/app/Services/services.html',
        })
        .when('/products/:id', {
            templateUrl: '/app/Products/products.html',
            controller: 'ProductController'
        })
        .when('/catalog/:id', {
            templateUrl: '/app/ProductCatalog/productcatalog.html',
            controller: 'CatalogController'
        })
        .when('/contact', {
            templateUrl: '/app/Contact/contact.html'
        })
        .when('/equipment', {
            templateUrl: '/app/Equipment/equipment.html'
        })
});
