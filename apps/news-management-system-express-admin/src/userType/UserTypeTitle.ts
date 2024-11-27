import { UserType as TUserType } from "../api/userType/UserType";

export const USERTYPE_TITLE_FIELD = "id";

export const UserTypeTitle = (record: TUserType): string => {
  return record.id?.toString() || String(record.id);
};
