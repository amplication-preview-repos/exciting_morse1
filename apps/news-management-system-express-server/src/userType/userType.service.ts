import { Injectable } from "@nestjs/common";
import { PrismaService } from "../prisma/prisma.service";
import { UserTypeServiceBase } from "./base/userType.service.base";

@Injectable()
export class UserTypeService extends UserTypeServiceBase {
  constructor(protected readonly prisma: PrismaService) {
    super(prisma);
  }
}
