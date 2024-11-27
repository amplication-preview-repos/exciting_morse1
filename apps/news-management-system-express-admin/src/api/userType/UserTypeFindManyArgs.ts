import { UserTypeWhereInput } from "./UserTypeWhereInput";
import { UserTypeOrderByInput } from "./UserTypeOrderByInput";

export type UserTypeFindManyArgs = {
  where?: UserTypeWhereInput;
  orderBy?: Array<UserTypeOrderByInput>;
  skip?: number;
  take?: number;
};
