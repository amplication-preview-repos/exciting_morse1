import { InputJsonValue } from "../../types";

export type NewsCreateInput = {
  description?: string | null;
  endDate?: Date | null;
  image?: InputJsonValue;
  startDate?: Date | null;
  title?: string | null;
};
