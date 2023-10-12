import { MENU_ICONS } from '@utils/constants';
import { 
    DashboardIcon,
    ReservationsIcon,
    StaffIcon,
    StatisticsIcon,
    RoomsIcon,
    SettingsIcon,
    IncidentIcon,
    MessageIcon,
    ExitIcon
} from '@components/atoms/Icons';

interface ItemIconMenuProps {
    iconType: string,
    className?: string,
    size?: string
}

const ItemIconMneu: React.FC<ItemIconMenuProps> = ({iconType,size, className}) => {

  const IconDictionary = {
    [MENU_ICONS.DASHBOARD]: DashboardIcon,
    [MENU_ICONS.RESERVATIONS]: ReservationsIcon,
    [MENU_ICONS.STAFF]: StaffIcon,
    [MENU_ICONS.STATISTICS]: StatisticsIcon,
    [MENU_ICONS.ROOMS]: RoomsIcon,
    [MENU_ICONS.SETTINGS]: SettingsIcon,
    [MENU_ICONS.INCIDENT]: IncidentIcon,
    [MENU_ICONS.MESSAGE]: MessageIcon,
    [MENU_ICONS.EXIT]: ExitIcon
  }

const IconConstructor = IconDictionary[iconType];

if (!IconConstructor) {
    return null;
}

return <IconConstructor size={size} className={className}/>;
}

export default ItemIconMneu