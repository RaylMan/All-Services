"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
class Access {
    constructor(id, accessName, timestamp) {
        this.id = id;
        this.accessName = accessName;
        this.timestamp = timestamp;
    }
}
exports.Access = Access;
var AccessEnum;
(function (AccessEnum) {
    AccessEnum["Admin"] = "Admin";
    AccessEnum["User"] = "User";
    AccessEnum["Company"] = "Company";
})(AccessEnum = exports.AccessEnum || (exports.AccessEnum = {}));
//# sourceMappingURL=Access.js.map