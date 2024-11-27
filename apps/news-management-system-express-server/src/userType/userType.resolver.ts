import * as graphql from "@nestjs/graphql";
import { UserTypeResolverBase } from "./base/userType.resolver.base";
import { UserType } from "./base/UserType";
import { UserTypeService } from "./userType.service";

@graphql.Resolver(() => UserType)
export class UserTypeResolver extends UserTypeResolverBase {
  constructor(protected readonly service: UserTypeService) {
    super(service);
  }
}
