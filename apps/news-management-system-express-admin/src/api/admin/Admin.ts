import { JsonValue } from "type-fest";

export type Admin = {
  createdAt: Date;
  email: string | null;
  id: string;
  logo: JsonValue;
  name: string | null;
  password: string | null;
  updatedAt: Date;
};
