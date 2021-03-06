﻿/// <reference path="../scripts/jasmine.js" />
/// <reference path="../../TaxiFareCalculator/scripts/angular.js" />
/// <reference path="../../TaxiFareCalculator/scripts/angular-mocks.js" />
/// <reference path="../../TaxiFareCalculator/js/taxiFareApp.js" />

describe('angularJs Ctrl => ', function () {

    beforeEach(module("taxiFareApp"));

    var scope, controller;

    describe('TaxiFareController Setup -', function () {
        
        beforeEach(inject(function ($rootScope, $controller, $http) {

            scope = $rootScope.$new();

            controller = $controller('taxiFareController', {
                $scope: scope,
                $http: $http
            });

        }));

        it('It should initialize', function () {
            expect(controller).not.toBeNull();
            expect(scope.CalculateFare).toBeDefined();
        });
    });
});