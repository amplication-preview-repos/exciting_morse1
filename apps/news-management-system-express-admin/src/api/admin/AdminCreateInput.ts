import { InputJsonValue } from "../../types";

export type AdminCreateInput = {
  email?: string | null;
  logo?: InputJsonValue;
  name?: string | null;
  password?: string | null;
};
