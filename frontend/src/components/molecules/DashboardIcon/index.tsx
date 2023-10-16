import { DASHBOARD_ICONS } from '@utils/constants';
import {
  RoomsIcon,
  ReservationInfoIcon,
  StaffIcon,
  IncidentsIcon,
  RoomsAvailableIcon,
  RoomsOcupiedIcon,
  PendingCheckInIcon,
  NewMessagesIcon,
} from '@components/atoms/Icons';

interface DashboardIconProps {
  iconType: string;
  className?: string;
  size?: string;
}

const DashboardIcon: React.FC<DashboardIconProps> = (props) => {
  const IconDictionary = {
    [DASHBOARD_ICONS.ROOMS]: RoomsIcon,
    [DASHBOARD_ICONS.RESERVATIONS]: ReservationInfoIcon,
    [DASHBOARD_ICONS.STAFF]: StaffIcon,
    [DASHBOARD_ICONS.INCIDENTS]: IncidentsIcon,
    [DASHBOARD_ICONS.ROOM_AVAILABLE]: RoomsAvailableIcon,
    [DASHBOARD_ICONS.ROOM_OCUPIED]: RoomsOcupiedIcon,
    [DASHBOARD_ICONS.PENDING]: PendingCheckInIcon,
    [DASHBOARD_ICONS.NEW_MESSAGE]: NewMessagesIcon,
  };

  const IconConstructor = IconDictionary[props.iconType];

  if (!IconConstructor) {
    return null;
  }
  return <IconConstructor size={props.size} className={props.className} />;
};

export default DashboardIcon;
