import { Module } from "@nestjs/common";
import { UserTypeModuleBase } from "./base/userType.module.base";
import { UserTypeService } from "./userType.service";
import { UserTypeController } from "./userType.controller";
import { UserTypeResolver } from "./userType.resolver";

@Module({
  imports: [UserTypeModuleBase],
  controllers: [UserTypeController],
  providers: [UserTypeService, UserTypeResolver],
  exports: [UserTypeService],
})
export class UserTypeModule {}
