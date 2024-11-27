/*
------------------------------------------------------------------------------ 
This code was generated by Amplication. 
 
Changes to this file will be lost if the code is regenerated. 

There are other ways to to customize your code, see this doc to learn more
https://docs.amplication.com/how-to/custom-code

------------------------------------------------------------------------------
  */
import * as graphql from "@nestjs/graphql";
import { GraphQLError } from "graphql";
import { isRecordNotFoundError } from "../../prisma.util";
import { MetaQueryPayload } from "../../util/MetaQueryPayload";
import { UserType } from "./UserType";
import { UserTypeCountArgs } from "./UserTypeCountArgs";
import { UserTypeFindManyArgs } from "./UserTypeFindManyArgs";
import { UserTypeFindUniqueArgs } from "./UserTypeFindUniqueArgs";
import { DeleteUserTypeArgs } from "./DeleteUserTypeArgs";
import { UserTypeService } from "../userType.service";
@graphql.Resolver(() => UserType)
export class UserTypeResolverBase {
  constructor(protected readonly service: UserTypeService) {}

  async _userTypesMeta(
    @graphql.Args() args: UserTypeCountArgs
  ): Promise<MetaQueryPayload> {
    const result = await this.service.count(args);
    return {
      count: result,
    };
  }

  @graphql.Query(() => [UserType])
  async userTypes(
    @graphql.Args() args: UserTypeFindManyArgs
  ): Promise<UserType[]> {
    return this.service.userTypes(args);
  }

  @graphql.Query(() => UserType, { nullable: true })
  async userType(
    @graphql.Args() args: UserTypeFindUniqueArgs
  ): Promise<UserType | null> {
    const result = await this.service.userType(args);
    if (result === null) {
      return null;
    }
    return result;
  }

  @graphql.Mutation(() => UserType)
  async deleteUserType(
    @graphql.Args() args: DeleteUserTypeArgs
  ): Promise<UserType | null> {
    try {
      return await this.service.deleteUserType(args);
    } catch (error) {
      if (isRecordNotFoundError(error)) {
        throw new GraphQLError(
          `No resource was found for ${JSON.stringify(args.where)}`
        );
      }
      throw error;
    }
  }
}
