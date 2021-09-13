"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var testing_1 = require("@angular/core/testing");
var businesstype_service_1 = require("./businesstype.service");
describe('BusinesstypeService', function () {
    beforeEach(function () { return testing_1.TestBed.configureTestingModule({}); });
    it('should be created', function () {
        var service = testing_1.TestBed.get(businesstype_service_1.BusinesstypeService);
        expect(service).toBeTruthy();
    });
});
//# sourceMappingURL=businesstype.service.spec.js.map