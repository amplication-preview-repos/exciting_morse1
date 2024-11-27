import { JsonValue } from "type-fest";

export type News = {
  createdAt: Date;
  description: string | null;
  endDate: Date | null;
  id: string;
  image: JsonValue;
  startDate: Date | null;
  title: string | null;
  updatedAt: Date;
};
