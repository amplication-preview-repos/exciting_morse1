import * as common from "@nestjs/common";
import * as swagger from "@nestjs/swagger";
import { UserTypeService } from "./userType.service";
import { UserTypeControllerBase } from "./base/userType.controller.base";

@swagger.ApiTags("userTypes")
@common.Controller("userTypes")
export class UserTypeController extends UserTypeControllerBase {
  constructor(protected readonly service: UserTypeService) {
    super(service);
  }
}
