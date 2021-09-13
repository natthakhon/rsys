"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var testing_1 = require("@angular/core/testing");
var title_service_1 = require("./title.service");
describe('TitleService', function () {
    beforeEach(function () { return testing_1.TestBed.configureTestingModule({}); });
    it('should be created', function () {
        var service = testing_1.TestBed.get(title_service_1.TitleService);
        expect(service).toBeTruthy();
    });
});
//# sourceMappingURL=title.service.spec.js.map