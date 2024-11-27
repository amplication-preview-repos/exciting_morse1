import { SortOrder } from "../../util/SortOrder";

export type AdminOrderByInput = {
  createdAt?: SortOrder;
  email?: SortOrder;
  id?: SortOrder;
  logo?: SortOrder;
  name?: SortOrder;
  password?: SortOrder;
  updatedAt?: SortOrder;
};
