import { InputJsonValue } from "../../types";

export type AdminUpdateInput = {
  email?: string | null;
  logo?: InputJsonValue;
  name?: string | null;
  password?: string | null;
};
