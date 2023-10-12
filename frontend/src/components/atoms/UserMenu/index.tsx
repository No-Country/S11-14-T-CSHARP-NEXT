'use client';
import { Dropdown, DropdownMenu, DropdownItem, DropdownTrigger, Avatar } from '@nextui-org/react';

interface AvatarProps {}

const UserMenu: React.FC<AvatarProps> = () => {
  return (
    <Dropdown placement='bottom-start'>
      <DropdownTrigger>
        <div className='bg-white rounded flex flex-row content-center items-center px-2 py-1 cursor-pointer'>
          <span className='font-roboto font-medium mr-3'>José Díaz</span>
          <Avatar src='https://i.pravatar.cc/150?u=a042581f4e29026024d' size='sm' />
        </div>
      </DropdownTrigger>
      <DropdownMenu aria-label='User Actions' variant='flat'>
        <DropdownItem key='settings'>My Settings</DropdownItem>
        <DropdownItem key='team_settings'>Team Settings</DropdownItem>
        <DropdownItem key='analytics'>Analytics</DropdownItem>
        <DropdownItem key='system'>System</DropdownItem>
        <DropdownItem key='configurations'>Configurations</DropdownItem>
        <DropdownItem key='help_and_feedback'>Help & Feedback</DropdownItem>
        <DropdownItem key='logout' color='danger'>
          Log Out
        </DropdownItem>
      </DropdownMenu>
    </Dropdown>
  );
};

export default UserMenu;
